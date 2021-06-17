using Przychodnia.Class.Calendar;
using Przychodnia.Class.DictionariesHanding;
using Przychodnia.Class.Doctor;
using Przychodnia.Class.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Przychodnia.Windows.Doctor
{
    /// <summary>
    /// Logika interakcji dla klasy WindowDoctorEditCalendarAdd.xaml
    /// </summary>
    public partial class WindowDoctorEditCalendarAdd : Window
    {
        public WindowDoctorEditCalendarAdd()
        {
            InitializeComponent();

            workingDayFrom.ItemsSource = ClassHelpers.GenerateListOfHours(new TimeSpan(7, 0, 0), new TimeSpan(20, 0, 0));
            workingDayTo.ItemsSource = ClassHelpers.GenerateListOfHours(new TimeSpan(7, 0, 0), new TimeSpan(20, 0, 0));
            AvailableDate.ItemsSource = ListOfAvaiableDates();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            if(workingDayFrom.SelectedItem == null || workingDayTo.SelectedItem == null || AvailableDate.SelectedItem == null)
            {
                MessageBox.Show("You cannot leave any empty combobox!");
                return;
            }

            ClassCalendar calendar = GetCalendarForCurrentDate();
            int dayId = ClassSqlCalendar.GetDayIdForCalendarDate(calendar.CalendarId, ((ClassCalendarDay)AvailableDate.SelectedItem).DateInDateTime.Day);

            ClassSqlCalendar.CreateTerm((TimeSpan)workingDayFrom.SelectedItem, (TimeSpan)workingDayTo.SelectedItem, ClassSqlCalendar.GetCalendarIdForDoctor(ClassLoggedDoctor.Doctor_Id, calendar.CalendarId), dayId, ClassSQLConnections.GetOfficeIdForDoctor(ClassLoggedDoctor.Doctor_Id), ClassLoggedDoctor.Doctor_Id, ((ClassCalendarDay)AvailableDate.SelectedItem).Date);
            this.DialogResult = true;
            this.Close();
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddWorkingDayFrom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            workingDayTo.ItemsSource = ClassHelpers.GenerateListOfHours((TimeSpan)(workingDayFrom.SelectedItem) + new TimeSpan(0, 15, 0), new TimeSpan(20, 0, 0));
        }

        private void AddWorkingDayTo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddWorkingDayDate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private List<ClassCalendarDay> ListOfAvaiableDates()
        {
            ClassCalendar calendar = GetCalendarForCurrentDate();
            List<ClassCalendarDay> allAvailableDays = ClassSqlCalendar.ListOfCalendarDays(calendar.CalendarId);
            List<ClassTerm> workingDays = ClassSqlCalendar.GetListOfWorkingDayInCurrentMonth(ClassLoggedDoctor.Doctor_Id);

            List<ClassCalendarDay> avaiableDates = new List<ClassCalendarDay>();

            foreach (ClassTerm term in workingDays)
            {
                foreach (ClassCalendarDay day in allAvailableDays)
                {
                    if (term.Date == day.DateInDateTime)
                    {
                        avaiableDates.Add(day);
                    }
                }
            }

            avaiableDates = allAvailableDays.Except(avaiableDates).ToList();

            return avaiableDates;
        }

        private ClassCalendar GetCalendarForCurrentDate()
        {
            //Get calendar from data base
            IEnumerable<ClassCalendar> query =
               from elem in ClassSqlCalendar.AlreadyCreatedCalendars()
               where elem.Month == DateTime.Now.Month
               select elem;
            if (!query.Any()) throw new Exception("Unable to find selected calendar in database");
            return query.First();
        }
    }
}