using Przychodnia.Class.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClinicUnitTests.Doctor
{
    public class Calendar
    {
        [Fact]
        public void TestGetListOfWorkingDayInCurrentMonth()
        {

        }

        [Fact]
        public void TestUpdateTerm()
        {
            SqlCalendar sql = new SqlCalendar();
            sql.UpdateTerm(4, "2021-07-05", 1);

            IEnumerable<ClassTerm> query =
                from elem in sql.TermsList()
                where elem.CalendarDay.CalendarDayId == 4 && elem.CalendarDoctor.CalendarDoctorId == 1 && elem.Date == DateTime.Parse("2021-07-05")
                select elem;

            Assert.Single(query);
        }

        [Theory]
        [InlineData(1,2,1)]
        public void TestGetDayIdForCalendarDate(int calendarId, int dayOfMonth, int expected)
        {
            SqlCalendar sql = new SqlCalendar();
            Assert.Equal(expected, sql.GetDayIdForCalendarDate(calendarId, dayOfMonth));
        }
    }
}
