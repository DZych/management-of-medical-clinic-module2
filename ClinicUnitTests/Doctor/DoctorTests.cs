using Microsoft.VisualStudio.TestTools.UnitTesting;
using Przychodnia.Class.Calendar;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;
using Przychodnia.Class.Login;

namespace ClinicUnitTests.Doctor
{
    public class DoctorTests : ITestCaseOrderer
    {
        public IEnumerable<TTestCase> OrderTestCases<TTestCase>(IEnumerable<TTestCase> testCases) where TTestCase : ITestCase
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void TestGetListOfWorkingDayInCurrentMonth()
        {
            SqlCalendar sql = new SqlCalendar();

            IEnumerable<ClassTerm> querry = from elem in sql.TestGetListOfWorkingDayInCurrentMonth2(2)
                                            where elem.Doctor.Doctor_id == 2
                                            select elem;
            Xunit.Assert.Single(querry);
        }

        [Fact]
        public void TestUpdateTerm()
        {
            SqlCalendar sql = new SqlCalendar();
            sql.UpdateTerm(1, new DateTime(2000, 3, 7), 2);
            IEnumerable<ClassTerm> querry = from elem in sql.ListOfTerms()
                                            where elem.TermId == 2 && elem.CalendarDay.CalendarDayId == 1
                                            select elem;

            Xunit.Assert.Single(querry);

        }

        [Fact]
        public void TestCreateTerm()
        {
            SqlCalendar sql = new SqlCalendar();
            sql.CreateTerm(new TimeSpan(15, 0, 0), new TimeSpan(16, 0, 0), 2, 6, 2, 1, new DateTime(2000, 5, 6));

            IEnumerable<ClassTerm> querry = from elem in sql.ListOfTerms()
                                            where elem.StartTime == new TimeSpan(15, 0, 0) && elem.EndTime == new TimeSpan(16, 0, 0) && elem.CalendarDoctor.CalendarDoctorId == 2
                                            && elem.CalendarDay.CalendarDayId == 6 && elem.Office.OfficeId == 2 && elem.Doctor.Doctor_id == 1 &&
                                            elem.Date == new DateTime(2000, 5, 6)
                                            select elem;
            Xunit.Assert.Single(querry);

        }

        [Theory]
        [InlineData(20, 100)]
        [InlineData(10, 200)]
        public void TestGetOfficeIdForDoctor(int idDoctor, int expected)
        {

            SqlConnections sql = new SqlConnections();
            Xunit.Assert.Equal(expected, sql.GetOfficeIdForDoctor(idDoctor));
        }

        [Theory]
        [InlineData("u1", "1", "Doctor")]
        [InlineData("u2", "2", "Doctor")]
        public void TestGetUserType(string login, string password, string expected)
        {
            SqlConnections sql = new SqlConnections();
            Xunit.Assert.Equal(expected, sql.GetUserType(login, password));
        }
        [Theory]
        [InlineData(5, 4, 1)]
        [InlineData(6, 3, 4)]
        public void TestGetCalendarIdForDoctor(int doctorId, int calendarId, int expected)
        {
            SqlCalendar sql = new SqlCalendar();
            Xunit.Assert.Equal(expected, sql.GetCalendarIdForDoctor(doctorId, calendarId));

        }


        [Fact]
        public void TestGenerateHours()
        {
            //Arange
            List<TimeSpan> expectedListofGenerateHours = new List<TimeSpan>() { new TimeSpan(7, 0, 0), new TimeSpan(7, 15, 0), new TimeSpan(7, 30, 0), new TimeSpan(7, 45, 0), new TimeSpan(8, 0, 0),
            new TimeSpan(8, 15, 0), new TimeSpan(8, 30, 0), new TimeSpan(8, 45, 0), new TimeSpan(9, 0, 0), new TimeSpan(9, 15, 0),new TimeSpan(9, 30, 0), new TimeSpan(9, 45, 0), new TimeSpan(10, 0, 0), new TimeSpan(10, 15, 0), new TimeSpan(10, 30, 0), new TimeSpan(10, 45, 0), new TimeSpan(11, 0, 0), new TimeSpan(11, 15, 0), new TimeSpan(11, 30, 0), new TimeSpan(11, 45, 0), new TimeSpan(12, 0, 0), new TimeSpan(12, 15, 0), new TimeSpan(12, 30, 0), new TimeSpan(12, 45, 0), new TimeSpan(13, 0, 0), new TimeSpan(13, 15, 0), new TimeSpan(13, 30, 0), new TimeSpan(13, 45, 0), new TimeSpan(14, 0, 0), new TimeSpan(14, 15, 0), new TimeSpan(14, 30, 0), new TimeSpan(14, 45, 0), new TimeSpan(15, 0, 0), new TimeSpan(15, 15, 0), new TimeSpan(15, 30, 0),new TimeSpan(15, 45, 0), new TimeSpan(16, 0, 0), new TimeSpan(16, 15, 0), new TimeSpan(16, 30, 0), new TimeSpan(16, 45, 0), new TimeSpan(17, 0, 0), new TimeSpan(17, 15, 0), new TimeSpan(17, 30, 0), new TimeSpan(17, 45, 0), new TimeSpan(18, 0, 0), new TimeSpan(18, 15, 0), new TimeSpan(18, 30, 0), new TimeSpan(18, 45, 0), new TimeSpan(19, 0, 0), new TimeSpan(19, 15, 0), new TimeSpan(19, 30, 0), new TimeSpan(19, 45, 0), new TimeSpan(20, 0, 0)
            };

            // Act
            List<TimeSpan> actualListofGenerateHours = ClassHelpers.GenerateListOfHours(new TimeSpan(7, 0, 0), new TimeSpan(20, 0, 0));

            // Assert
            Xunit.Assert.Equal(expectedListofGenerateHours, actualListofGenerateHours);
        }


        [Theory]
        [InlineData("u1", "1", 1)]
        [InlineData("u2", "2", 2)]
        [InlineData("u3", "3", 3)]


        public void TestGetLoggedDoctorId(string login, string password, int expected)
        {

            SqlConnections sql = new SqlConnections();

            Xunit.Assert.Equal(expected, sql.GetLoggedDoctorId(login, password));


        }

        [Fact]
        public void TestGetAllAppoitments()
        {
            SqlAppointment sql = new SqlAppointment();

            IEnumerable<ClassAppointment> querry = from elem in sql.GetAllAppoitments()
                                                   where elem.Doctor.Doctor_id == 1 && elem.AppointmendtId == 1 && elem.Patient.PatientId == 1
                                                   select elem;
            Xunit.Assert.Single(querry);


        }
        [Theory]
        [InlineData(1,"Badania3", "badania3")]
        [InlineData(2, "Badania4", "badania4")]
        public void TestUpdateAppointment(int appointmentId, string description, string topic) 
        {
            SqlAppointment sql = new SqlAppointment();
            sql.UpdateAppointment(appointmentId, description, topic);

            IEnumerable<ClassAppointment> querry = from elem in sql.GetAllAppoitments()
                                                   where elem.AppointmendtId == 1 && elem.Description == "Badania3" && elem.Topic == "badania3"
                                                   select elem;

            Xunit.Assert.Single(querry);

        
        }
        [Fact]
        public void TestAppointmentsDateForCombobox()
        {
            SqlAppointment sql = new SqlAppointment();

            IEnumerable<ClassTerm> querry = from elem in sql.AppointmentsDateForCombobox()
                                            where elem.TermId == 1 && elem.StartTime== new TimeSpan(7,0,0)
                                            select elem;

            Xunit.Assert.Single(querry);



        }




















    }
}
