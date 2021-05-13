﻿using System;
using System.Collections.Generic;
using System.Text;
using Przychodnia.Class.DictionariesHanding;
namespace Przychodnia.Class.Calendar
{
    public static class ClassGenerateCalendar
    {
        public static void GenerateCalendar(int Year, int Month)
        {
            //Check if calendar for next month wasn't already created 
            if(CalendarAlreadyCreated(Year,Month)) throw new Exception("Calendar already created for next month");

            //Create list of working days for clinic
            List<int> daysInMonth = WorkingDaysInMonth(Year, Month);
              
            //Create Calendar
            int calendarId = ClassSqlCalendar.CreateCalendar(Year, Month);

            //Create querry
            string querry = "";
            foreach (int day in daysInMonth)
            {
                querry += String.Format("({0},'{1}','{2}',{3}),", day, new TimeSpan(7, 0, 0), new TimeSpan(20, 0, 0), calendarId);
            }
            if (querry.Length == 0) return;
            querry = Login.ClassHelpers.RemoveLastCharOfString(querry);
            
            //Create calendar days
            ClassSqlCalendar.CreateCalendarDays(querry);
        }

        public static void ShareCalendar(ClassCalendar calendar)
        {
            int Year= calendar.Year;
            int Month= calendar.Month;
            int calendarId = calendar.CalendarId;

            //List of Active doctors
            List<ClassDoctor> DoctorList = ListOfActiveDoctors();

            //List of calendar days
            List<ClassCalendarDay> dayList = ClassSqlCalendar.ListOfCalendarDays(calendarId);

            string querry = "";
            foreach (ClassDoctor dct in DoctorList)
            {
                //Create calendar doctor
                int calendarDoctorId = ClassSqlCalendar.CreateCalendarDoctor(dct.Doctor_id, calendarId);

                //Querry for terms for doctor
                querry += QuerryTermsForDoctor(Year, Month, calendarDoctorId, calendarId, dct, dayList);
            }
            if (querry.Length == 0) return;
            querry = Login.ClassHelpers.RemoveLastCharOfString(querry);
            //Add new terms
            ClassSqlCalendar.CreateTerms(querry);

            //Update calendar status
            ClassSqlCalendar.UpdateCalendarStatus(ClassSqlCalendar.SelectStatusId(EnumStatus.SharedForDoctors), calendarId);
        }

        #region Private methods

        #region Generate calendar helpers
        private static bool CalendarAlreadyCreated(int Year, int Month)
        {
            List<ClassCalendar> calendarList = ClassSqlCalendar.AlreadyCreatedCalendars();
            foreach (ClassCalendar item in calendarList)
            {
                if (item.Year == Year && item.Month == Month) return true;
            }
            return false;
        }
        private static List<int> WorkingDaysInMonth(int Year, int Month)
        {
            List<int> daysInMonth = new List<int>();
            DateTime day = new DateTime(Year, Month, 1);
            do
            {
                if (day.DayOfWeek != DayOfWeek.Sunday)
                {
                    daysInMonth.Add(day.Day);
                }
                day = day.AddDays(1);
            }
            while (day.Month == Month);
            return daysInMonth;
        }
        #endregion

        #region Share calendar helpers
        private static List<ClassDoctor> ListOfActiveDoctors()
        {
            List<ClassDoctor> allDoctorList = ClassSQLConnections.DoctorList();
            List<ClassDoctor> DoctorList = new List<ClassDoctor>();
            foreach (ClassDoctor item in allDoctorList)
            {
                if (item.Active == true) DoctorList.Add(item);
            }
            return DoctorList;
        }
        private static string QuerryTermsForDoctor(int Year, int Month, int calendarDoctorId, int calendarId, ClassDoctor dct, List<ClassCalendarDay> dayList)
        {
            string querry = "";
            foreach (ClassCalendarDay d in dayList)
            {
                DateTime data = new DateTime(Year, Month, d.Day);
                foreach (var item in ClassSqlCalendar.ListFixedTermsForSpecifiedDoctor(dct.Doctor_id))
                {
                    if ((int)data.DayOfWeek == item.Day)
                    {
                        if (item.Start >= d.StartTime && item.End <= d.EndTime)
                        {
                            querry += String.Format("('{0}','{1}','{2}',{3},{4},{5},{6}),", item.Start, item.End, String.Format("{0}-{1}-{2}", data.Year, data.Month, data.Day), calendarDoctorId, ClassSqlCalendar.SelectCalendarDayId(d.Day, calendarId), dct.OfficeNumber, dct.Doctor_id);
                        }
                        break;
                    }
                }
            }
            return querry;
        }
        #endregion

        #endregion
    }
}
