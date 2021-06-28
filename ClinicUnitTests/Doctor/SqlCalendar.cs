using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Przychodnia.Class.Calendar;
using Przychodnia.Class.DictionariesHanding;


namespace ClinicUnitTests.Doctor
{
    class SqlCalendar
    {
        public SqlCalendar()
        {
            #region Calendar
            ClassTerm t1 = new ClassTerm();
            t1.TermId = 1;
            t1.CalendarDay = new ClassCalendarDay();
            t1.CalendarDoctor = new ClassCalendarDoctor();
            t1.CalendarDoctor.CalendarDoctorId = 1;
            t1.CalendarDay.CalendarDayId = 1;
            t1.StartTime = new TimeSpan(12,0,0);
            t1.EndTime = new TimeSpan(18, 0, 0);
            t1.Date = new DateTime(2000, 3, 5);
            t1.Doctor = new ClassDoctor();
            t1.Doctor.Doctor_id = 1;
            t1.IsWorkingDay = true;
            
            

            ListTerm.Add(t1);


            ClassTerm t2 = new ClassTerm();
            t2.TermId = 2;
            t2.CalendarDay = new ClassCalendarDay();
            t2.CalendarDay.CalendarDayId = 5;
            t2.CalendarDoctor = new ClassCalendarDoctor();
            t2.CalendarDoctor.CalendarDoctorId = 2;
            t2.StartTime = new TimeSpan(8, 0, 0);
            t2.EndTime = new TimeSpan(15, 0, 0);
            t2.Date = new DateTime(2000, 3, 7);
            t2.Doctor = new ClassDoctor();
            t2.Doctor.Doctor_id=2;
            t2.IsWorkingDay = true;
            
            ListTerm.Add(t2);




            ClassCalendarDoctor c1 = new ClassCalendarDoctor();
            c1.CalendarDoctorId = 1;
            c1.Doctor = new ClassDoctor();
            c1.Doctor.Doctor_id = 5;
            c1.Calendar = new ClassCalendar();
            c1.Calendar.CalendarId = 4;

            ClassCalendarDoctor c2 = new ClassCalendarDoctor();
            c2.CalendarDoctorId = 4;
            c2.Doctor = new ClassDoctor();
            c2.Doctor.Doctor_id = 6;
            c2.Calendar = new ClassCalendar();
            c2.Calendar.CalendarId = 3;

            ListCalendarForDoctor = new List<ClassCalendarDoctor>() { c1, c2 };











            #endregion

        }

        #region Variables
        static List<ClassTerm> ListTerm = new List<ClassTerm>();
        static List<ClassCalendarDoctor> ListCalendarForDoctor;
        #endregion

        public  List<ClassTerm> TestGetListOfWorkingDayInCurrentMonth2(int doctor_id)
        {
            List<ClassTerm> ListTerm2 = new List<ClassTerm>();
            foreach (ClassTerm t in ListTerm)
            {
                if (t.Doctor.Doctor_id == doctor_id)
                {
                    ListTerm2.Add(t);
                }
            }
            return ListTerm2;
        }

        public void UpdateTerm(int CalendarDayId, DateTime date, int TermId) 
        {
            foreach (var t in ListTerm) 
            {
                if (t.TermId == TermId) 
                {
                    t.Date = date;
                    t.CalendarDay.CalendarDayId = CalendarDayId;

                }
            
            }


        }
        public List<ClassTerm> ListOfTerms()
        {
            return ListTerm;
        }

        public void CreateTerm(TimeSpan startTime, TimeSpan endTime, int CalendarDoctorId, int CalendarDayId, int OfficeId, int doctorID, DateTime Date) 
        {
            ClassTerm term = new ClassTerm();
            term.StartTime = startTime;
            term.EndTime = endTime ;
            term.CalendarDoctor = new ClassCalendarDoctor();
            term.CalendarDoctor.CalendarDoctorId = CalendarDoctorId;
            term.CalendarDay = new ClassCalendarDay();
            term.CalendarDay.CalendarDayId = CalendarDayId;
            term.Office = new ClassOffice();
            term.Office.OfficeId = OfficeId;
            term.Doctor = new ClassDoctor();
            term.Doctor.Doctor_id = doctorID;
            term.Date = Date;
            ListTerm.Add(term);

        }

        /*  public int GetDayIdForCalendarDay(int calendarId, int dayOfYear) 
          {
              int dayId = 0;

             return 
          }*/

        public int GetCalendarIdForDoctor(int doctorId, int calendarId) 
        {

            int calendarforDoctorID = 0;
            foreach (var c in ListCalendarForDoctor) 
            {
                if (c.Doctor.Doctor_id == doctorId) 
                {
                    calendarforDoctorID = c.CalendarDoctorId;
                }
            }

            return calendarforDoctorID;
        
        
        }
    }
}
