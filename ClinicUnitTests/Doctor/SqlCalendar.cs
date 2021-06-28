using Przychodnia.Class.Calendar;
using Przychodnia.Class.DictionariesHanding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClinicUnitTests.Doctor
{
    public class SqlCalendar
    {
        public SqlCalendar()
        {
            #region Doctor
            ClassDoctor dct1 = new ClassDoctor();
            dct1.Active = true;
            dct1.Doctor_id = 1;
            dct1.Name = "Jan";
            dct1.Surname = "Nowak";
            dct1.OfficeNumber = 100;
            ClassDoctor dct2 = new ClassDoctor();
            dct2.Active = true;
            dct2.Doctor_id = 2;
            dct2.Name = "Tomasz";
            dct2.Surname = "Kowalski";
            dct2.OfficeNumber = 200;
            #endregion

            #region Calendar Doctor
            ClassCalendarDoctor cd1 = new ClassCalendarDoctor();
            cd1.Calendar = new ClassCalendar();
            cd1.Calendar.CalendarId = 2;
            cd1.CalendarDoctorId = 1;
            cd1.Doctor = new ClassDoctor();
            cd1.Doctor.Doctor_id = 1;
            cd1.Status = new ClassStatus();
            cd1.Status.StatusId = 7;

            ClassCalendarDoctor cd2 = new ClassCalendarDoctor();
            cd2.Calendar = new ClassCalendar();
            cd2.Calendar.CalendarId = 2;
            cd2.CalendarDoctorId = 2;
            cd2.Doctor = new ClassDoctor();
            cd2.Doctor.Doctor_id = 2;
            cd2.Status = new ClassStatus();
            cd2.Status.StatusId = 7;
            #endregion

            #region Calendar Day
            ClassCalendarDay d1 = new ClassCalendarDay();
            d1.Calendar = new ClassCalendar();
            d1.Calendar.CalendarId = 1;
            d1.CalendarDayId = 1;
            d1.DateInDateTime = new DateTime(2021,7,1);
            d1.Day = 1;
            d1.StartTime = new TimeSpan(7, 0, 0);
            d1.EndTime = new TimeSpan(20, 0, 0);
            ListCalendarDay.Add(d1);

            ClassCalendarDay d2 = new ClassCalendarDay();
            d2.Calendar = new ClassCalendar();
            d2.Calendar.CalendarId = 1;
            d2.CalendarDayId = 2;
            d2.DateInDateTime = new DateTime(2021, 7, 2);
            d2.Day = 2;
            d2.StartTime = new TimeSpan(7, 0, 0);
            d2.EndTime = new TimeSpan(20, 0, 0);
            ListCalendarDay.Add(d1);

            ClassCalendarDay d3 = new ClassCalendarDay();
            d3.Calendar = new ClassCalendar();
            d3.Calendar.CalendarId = 2;
            d3.CalendarDayId = 3;
            d1.DateInDateTime = new DateTime(2021, 7, 1);
            d3.Day = 1;
            d3.StartTime = new TimeSpan(7, 0, 0);
            d3.EndTime = new TimeSpan(20, 0, 0);
            ListCalendarDay.Add(d1);

            ClassCalendarDay d4 = new ClassCalendarDay();
            d4.Calendar = new ClassCalendar();
            d4.Calendar.CalendarId = 2;
            d4.CalendarDayId = 4;
            d1.DateInDateTime = new DateTime(2021, 7, 7);
            d4.Day = 7;
            d4.StartTime = new TimeSpan(7, 0, 0);
            d4.EndTime = new TimeSpan(20, 0, 0);
            ListCalendarDay.Add(d1);
            #endregion

            #region Term
            ClassTerm t1 = new ClassTerm();
            t1.TermId = 1;
            t1.CalendarDay = new ClassCalendarDay();
            t1.CalendarDay = d3;
            t1.CalendarDoctor = cd1;
            t1.Date = new DateTime(2000, 3, 1);
            t1.Doctor = dct1;
            t1.StartTime = new TimeSpan(8, 0, 0);
            t1.EndTime = new TimeSpan(12, 0, 0);
            t1.Office = new ClassOffice();
            t1.Office.OfficeNumber = 100;
            ListTerm.Add(t1);

            ClassTerm t2 = new ClassTerm();
            t2.TermId = 2;
            t2.CalendarDay = new ClassCalendarDay();
            t2.CalendarDay = d4;
            t2.CalendarDoctor = cd2;
            t2.Date = new DateTime(2000, 3, 7);
            t2.Doctor = dct2;
            t2.StartTime = new TimeSpan(13, 0, 0);
            t2.EndTime = new TimeSpan(15, 0, 0);
            t2.Office = new ClassOffice();
            t2.Office.OfficeNumber = 200;
            ListTerm.Add(t2);
            #endregion
        }

        private List<ClassTerm> ListTerm = new List<ClassTerm>();
        private List<ClassCalendarDay> ListCalendarDay = new List<ClassCalendarDay>();

        public void UpdateTerm(int CalendarDayId, string date, int TermId)
        {
            foreach(var item in ListTerm)
            {
                if(item.TermId == TermId)
                {
                    item.Date = DateTime.Parse(date);
                    item.CalendarDay.CalendarDayId = CalendarDayId;
                }
            }
        }

        public List<ClassTerm> TermsList()
        {
            return ListTerm;
        }

        public int GetDayIdForCalendarDate(int calendarId, int dayOfMonth)
        {
            foreach (var item in ListCalendarDay)
            {
                if(item.Calendar.CalendarId == calendarId && item.Day == dayOfMonth)
                {
                    return item.Day;
                }
            }
            return 0;
        }
    }
}
