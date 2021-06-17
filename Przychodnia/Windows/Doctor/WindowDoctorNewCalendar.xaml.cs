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
                if (ComboBoxPickCalendar.Items.Count == 0) this.Loaded += (a, b) => NavigationService.Navigate(new WindowDoctorNewCalendarEmpty());
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

            PreviousMonthDataGrid.ItemsSource = ClassSqlCalendar.GetListOfWorkingDayInCurrentMonth(ClassLoggedDoctor.Doctor_Id);
        }

        #region Variables
        List<ClassCalendarDay> days = new List<ClassCalendarDay>();
        ClassCalendarDay lastSelectedDay = null;
        int lastSelectedIndex = 0;
        #endregion

        private void CheckBoxWorkingDay_Checked(object sender, RoutedEventArgs e)
        {
            workingDayFrom.IsEnabled = true;
            workingDayTo.IsEnabled = true;

            ClassCalendarDay day = (ClassCalendarDay)CurrentMonthDataGrid.SelectedItem;
            RefreshLastSelectedItems(day);

            day.IsWorkingDay = true;
           // day.StartTime = ListOfOriginalDays()[lastSelectedIndex].StartTime;
           // day.EndTime = ListOfOriginalDays()[lastSelectedIndex].EndTime;
            days.RemoveAt(CurrentMonthDataGrid.SelectedIndex);
            days.Insert(CurrentMonthDataGrid.SelectedIndex, day);

            RefreshDataGrid();

            workingDayFrom.ItemsSource = ClassHelpers.GenerateListOfHours(ListOfOriginalDays()[lastSelectedIndex].StartTime, ListOfOriginalDays()[lastSelectedIndex].EndTime - new TimeSpan(0, 15, 0));
            workingDayFrom.SelectedItem = lastSelectedDay.StartTime;
            workingDayTo.ItemsSource = ClassHelpers.GenerateListOfHours((TimeSpan)workingDayFrom.Items[workingDayFrom.SelectedIndex + 1], ListOfOriginalDays()[lastSelectedIndex].EndTime);
            workingDayTo.SelectedIndex = workingDayTo.Items.Count - 1;
        }

        private List<ClassCalendarDay> ListOfOriginalDays()
        {
            ClassCalendar calendar = GetCalendarForSelectedCalendarInComboboxFromDataBase();
            List<ClassCalendarDay> orignalDays = ClassSqlCalendar.ListOfCalendarDays(calendar.CalendarId);
            return orignalDays;
        }

        private void CheckBoxWorkingDay_Unchecked(object sender, RoutedEventArgs e)
        {
            workingDayFrom.IsEnabled = false;
            workingDayTo.IsEnabled = false;

            ClassCalendarDay day = (ClassCalendarDay)CurrentMonthDataGrid.SelectedItem;
            RefreshLastSelectedItems(day);

            day.IsWorkingDay = false;
            //day.StartTime = ListOfOriginalDays()[lastSelectedIndex].StartTime;
           // day.EndTime = ListOfOriginalDays()[lastSelectedIndex].EndTime;
            days.RemoveAt(CurrentMonthDataGrid.SelectedIndex);
            days.Insert(CurrentMonthDataGrid.SelectedIndex, day);

            RefreshDataGrid();

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
                {
                    workingDay.IsChecked = true;
                }
                    
                else
                    workingDay.IsChecked = false;
            }
            else if (day.IsWorkingDay == true)
            {
                workingDay.IsChecked = true;
            }
                
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


        private void RefreshDataGrid()
        {
            CurrentMonthDataGrid.ItemsSource = null;
            CurrentMonthDataGrid.ItemsSource = days;
            CurrentMonthDataGrid.SelectedIndex = lastSelectedIndex;
        }

        private void RefreshLastSelectedItems(ClassCalendarDay day)
        {
            lastSelectedDay = day;
            lastSelectedIndex = CurrentMonthDataGrid.SelectedIndex;
        }

        private void workingDayFrom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (workingDayFrom.SelectedItem != null)
            {
                lastSelectedDay.StartTime = (TimeSpan)workingDayFrom.SelectedItem;
                days.RemoveAt(CurrentMonthDataGrid.SelectedIndex);
                days.Insert(CurrentMonthDataGrid.SelectedIndex, lastSelectedDay);

                RefreshDataGrid();

                if (workingDayFrom.SelectedIndex == workingDayFrom.Items.Count - 1)
                {
                    workingDayTo.ItemsSource = ClassHelpers.GenerateListOfHours((TimeSpan)workingDayFrom.Items[workingDayFrom.SelectedIndex], lastSelectedDay.EndTime + new TimeSpan(0, 15, 0));
                }
                else
                {
                    workingDayTo.ItemsSource = ClassHelpers.GenerateListOfHours((TimeSpan)workingDayFrom.Items[workingDayFrom.SelectedIndex + 1], ListOfOriginalDays()[lastSelectedIndex].EndTime);
                }

                if ((TimeSpan)workingDayFrom.SelectedItem > lastSelectedDay.EndTime)
                {
                    workingDayTo.ItemsSource = ClassHelpers.GenerateListOfHours((TimeSpan)workingDayFrom.Items[workingDayFrom.SelectedIndex + 1], ListOfOriginalDays()[lastSelectedIndex].EndTime);
                    workingDayTo.SelectedIndex = 0;
                }
            }
        }
        private void workingDayTo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (workingDayTo.SelectedItem != null)
            {
                lastSelectedDay.EndTime = (TimeSpan)workingDayTo.SelectedItem;

                days.RemoveAt(CurrentMonthDataGrid.SelectedIndex);
                days.Insert(CurrentMonthDataGrid.SelectedIndex, lastSelectedDay);

                RefreshDataGrid();
            }
        }

        private void CurrentMonthDataGrid_LostFocus(object sender, RoutedEventArgs e)
        {
            ClassCalendarDay day = (ClassCalendarDay)CurrentMonthDataGrid.SelectedItem;
            RefreshLastSelectedItems(day);
        }

        private void Button_AcceptCalendarClick(object sender, RoutedEventArgs e)
        {
            ClassCalendar calendar = GetCalendarForSelectedCalendarInComboboxFromDataBase();
            foreach (ClassCalendarDay day in days)
            {
                if (day.IsWorkingDay == true)
                {
                    int dayId = ClassSqlCalendar.GetDayIdForCalendarDate(calendar.CalendarId, day.DateInDateTime.Day);
                    
                    ClassSqlCalendar.CreateTerm(day.StartTime, day.EndTime, ClassSqlCalendar.GetCalendarIdForDoctor(ClassLoggedDoctor.Doctor_Id, calendar.CalendarId) , dayId, ClassSQLConnections.GetOfficeIdForDoctor(ClassLoggedDoctor.Doctor_Id), ClassLoggedDoctor.Doctor_Id, day.Date);

                }
            }

            ClassSqlCalendar.UpdateCalendarStatus(ClassSqlCalendar.SelectStatusId(EnumStatus.AcceptedByTheDoctor), calendar.CalendarId);
            NavigationService.Navigate(new WindowDoctorNewCalendarEmpty());
        }

        private void copyPreviousMonth_Click(object sender, RoutedEventArgs e)
        {
            List<ClassTerm> previousDays = ClassSqlCalendar.GetListOfWorkingDayInCurrentMonth(ClassLoggedDoctor.Doctor_Id);

            foreach(ClassTerm previousDay in previousDays)
            {
                var date = previousDay.Date.AddDays(28);
                foreach(ClassCalendarDay day in days)
                {
                    if(day.DateInDateTime == date)
                    {
                            day.IsWorkingDay = true;
                    }
                }
            }

            RefreshDataGrid();
        }
    }
}
