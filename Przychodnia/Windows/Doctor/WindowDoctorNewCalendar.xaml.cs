using Przychodnia.Class.Calendar;
using Przychodnia.Class.Doctor;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Przychodnia.Windows.Doctor
{
    /// <summary>
    /// Logika interakcji dla klasy WindowsDoctorNewCalendar.xaml
    /// </summary>
    public partial class WindowDoctorNewCalendar : Page
    {
        public WindowDoctorNewCalendar()
        {
            InitializeComponent();

            #region Load calendars to ComboBox
            try
            {
                ComboBoxPickCalendar.ItemsSource = ClassSqlCalendar.AlreadyCreatedCalendarsForDoctor();
                if (ComboBoxPickCalendar.Items.Count == 0) return;
                ComboBoxPickCalendar.SelectedIndex = ComboBoxPickCalendar.Items.Count - 1;
                LoadDateToGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

            if (CurrentMonthDataGrid.SelectedIndex == -1)
                workingDay.IsEnabled = false;
        }

        List<ClassCalendarDay> days = new List<ClassCalendarDay>();
        ClassCalendarDay lastSelectedDay = null;
        int lastSelectedIndex = 0;

        private void CheckBoxWorkingDay_Checked(object sender, RoutedEventArgs e)
        {
            workingDayFrom.IsEnabled = true;
            workingDayTo.IsEnabled = true;

            ClassCalendarDay day = (ClassCalendarDay)CurrentMonthDataGrid.SelectedItem;
            lastSelectedDay = day;
            lastSelectedIndex = CurrentMonthDataGrid.SelectedIndex;
            day.IsWorkingDay = true;
            days.RemoveAt(CurrentMonthDataGrid.SelectedIndex);
            days.Insert(CurrentMonthDataGrid.SelectedIndex, day);

            CurrentMonthDataGrid.ItemsSource = null;
            CurrentMonthDataGrid.ItemsSource = days;
            CurrentMonthDataGrid.SelectedIndex = lastSelectedIndex;

            workingDayFrom.ItemsSource = GenerateListOfHours(day.StartTime, day.EndTime);
            workingDayTo.ItemsSource = GenerateListOfHours(day.StartTime, day.EndTime);
        }

        private void CheckBoxWorkingDay_Unchecked(object sender, RoutedEventArgs e)
        {
            workingDayFrom.IsEnabled = false;
            workingDayTo.IsEnabled = false;

            ClassCalendarDay day = (ClassCalendarDay)CurrentMonthDataGrid.SelectedItem;
            lastSelectedDay = day;
            lastSelectedIndex = CurrentMonthDataGrid.SelectedIndex;
            day.IsWorkingDay = false;
            days.RemoveAt(CurrentMonthDataGrid.SelectedIndex);
            days.Insert(CurrentMonthDataGrid.SelectedIndex, day);

            CurrentMonthDataGrid.ItemsSource = null;
            CurrentMonthDataGrid.ItemsSource = days;
            CurrentMonthDataGrid.SelectedIndex = lastSelectedIndex;

            workingDayFrom.ItemsSource = null;
            workingDayTo.ItemsSource = null;
        }

        private void CurrentMonthDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            workingDay.IsEnabled = true;
            ClassCalendarDay day = (ClassCalendarDay)CurrentMonthDataGrid.SelectedItem;
            if (day == null)
            {
                if (lastSelectedDay.IsWorkingDay == true)
                    workingDay.IsChecked = true;
                else
                    workingDay.IsChecked = false;
            }
            else if (day.IsWorkingDay == true)
                workingDay.IsChecked = true;
            else
                workingDay.IsChecked = false;
        }

        private void ComboBoxPickDate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LoadDateToGrid()
        {
            if (ComboBoxPickCalendar.SelectedIndex == -1)
            {
                CurrentMonthDataGrid.ItemsSource = null;
                return;
            }
            try
            {
                ClassCalendar calendar = GetCalendarForSelectedCalendarInComboboxFromDataBase();

                CurrentMonthDataGrid.ItemsSource = ClassSqlCalendar.ListOfCalendarDays(calendar.CalendarId);
                days = ClassSqlCalendar.ListOfCalendarDays(calendar.CalendarId);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private ClassCalendar GetCalendarForSelectedCalendarInComboboxFromDataBase()
        {
            if (ComboBoxPickCalendar.SelectedIndex == -1) throw new Exception("Calendar isn't selected");

            //Get calendar from data base
            IEnumerable<ClassCalendar> query =
               from elem in ClassSqlCalendar.AlreadyCreatedCalendars()
               where elem.CalendarId == ((ClassCalendar)ComboBoxPickCalendar.SelectedItem).CalendarId
               select elem;
            if (!query.Any()) throw new Exception("Unable to find selected calendar in database");
            return query.First();
        }

        private void PrintInfo(object sender, MouseButtonEventArgs e)
        {
            ClassCalendarDay day = (ClassCalendarDay)CurrentMonthDataGrid.SelectedItem;
            label1.Content = ClassLoggedDoctor.Doctor_Id;
        }

        private List<TimeSpan> GenerateListOfHours(TimeSpan start, TimeSpan stop)
        {
            List<TimeSpan> Times = new List<TimeSpan>();

            for (var i = start; i <= stop; i = i + new TimeSpan(0,15,0))
            {
                Times.Add(i);
            }

            return Times;
        }
    }
}
