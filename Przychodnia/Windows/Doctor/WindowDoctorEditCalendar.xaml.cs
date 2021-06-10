using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Przychodnia.Class.Doctor;
using System.Windows.Controls;
using Przychodnia.Class.Calendar;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Przychodnia.Class.Calendar;
using System.Linq;
using Przychodnia.Class.Login;

namespace Przychodnia.Windows.Doctor
{
    /// <summary>
    /// Logika interakcji dla klasy WindowDoctorEditCalendar.xaml
    /// </summary>
    public partial class WindowDoctorEditCalendar : Page
    {
        public WindowDoctorEditCalendar()
        {
            InitializeComponent();

            List<ClassTerm> ListOfTerms = ClassSqlCalendar.GetListOfWorkingDayInCurrentMonth(ClassLoggedDoctor.Doctor_Id);
            CurrentMonthDataGrid.ItemsSource = ListOfTerms;
            CurrentMonthDataGrid.SelectedIndex = 0;
        }

        #region Variables
        List<ClassTerm> ListOfTerms = ClassSqlCalendar.GetListOfWorkingDayInCurrentMonth(ClassLoggedDoctor.Doctor_Id);
        ClassTerm lastSelectedTerm = null;
        int lastSelectedIndex = 0;
        #endregion

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowDoctorEditCalendarAdd windowDoctorEditCalendarAdd = new WindowDoctorEditCalendarAdd();
            var dialogResult = windowDoctorEditCalendarAdd.ShowDialog();
            if (windowDoctorEditCalendarAdd.DialogResult == true)
            {
                ListOfTerms = ClassSqlCalendar.GetListOfWorkingDayInCurrentMonth(ClassLoggedDoctor.Doctor_Id);
                RefreshDataGrid();
            }
        }

        private void workingDayFrom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (workingDayFrom.SelectedItem != null)
            {
                lastSelectedTerm.StartTime = (TimeSpan)workingDayFrom.SelectedItem;
                ListOfTerms.RemoveAt(CurrentMonthDataGrid.SelectedIndex);
                ListOfTerms.Insert(CurrentMonthDataGrid.SelectedIndex, lastSelectedTerm);

                RefreshDataGrid();

                if (workingDayFrom.SelectedIndex == workingDayFrom.Items.Count - 1)
                {
                    workingDayTo.ItemsSource = ClassHelpers.GenerateListOfHours((TimeSpan)workingDayFrom.Items[workingDayFrom.SelectedIndex], ListOfOriginalDays()[lastSelectedIndex].EndTime);
                }
                else
                {
                    workingDayTo.ItemsSource = ClassHelpers.GenerateListOfHours((TimeSpan)workingDayFrom.Items[workingDayFrom.SelectedIndex + 1], ListOfOriginalDays()[lastSelectedIndex].EndTime);
                }

                if ((TimeSpan)workingDayFrom.SelectedItem > lastSelectedTerm.EndTime)
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
                lastSelectedTerm.EndTime = (TimeSpan)workingDayTo.SelectedItem;

                ListOfTerms.RemoveAt(CurrentMonthDataGrid.SelectedIndex);
                ListOfTerms.Insert(CurrentMonthDataGrid.SelectedIndex, lastSelectedTerm);

                RefreshDataGrid();
            }
        }

        private void CheckBoxWorkingDay_Unchecked(object sender, RoutedEventArgs e)
        {
            workingDayFrom.IsEnabled = false;
            workingDayTo.IsEnabled = false;

            ClassTerm term = (ClassTerm)CurrentMonthDataGrid.SelectedItem;
            RefreshLastSelectedItems(term);

            lastSelectedTerm.IsWorkingDay = false;
            ListOfTerms.RemoveAt(CurrentMonthDataGrid.SelectedIndex);
            ListOfTerms.Insert(CurrentMonthDataGrid.SelectedIndex, term);

            RefreshDataGrid();


            workingDayFrom.ItemsSource = null;
            workingDayTo.ItemsSource = null;
        }

        private void CheckBoxWorkingDay_Checked(object sender, RoutedEventArgs e)
        {
            workingDayFrom.IsEnabled = true;
            workingDayTo.IsEnabled = true;

            ClassTerm term = (ClassTerm)CurrentMonthDataGrid.SelectedItem;
            RefreshLastSelectedItems(term);

            lastSelectedTerm.IsWorkingDay = true;
            ListOfTerms.RemoveAt(CurrentMonthDataGrid.SelectedIndex);
            ListOfTerms.Insert(CurrentMonthDataGrid.SelectedIndex, lastSelectedTerm);

            RefreshDataGrid();

            workingDayFrom.ItemsSource = ClassHelpers.GenerateListOfHours(new TimeSpan(7, 0, 0), new TimeSpan(19, 45, 0));
            workingDayFrom.SelectedItem = lastSelectedTerm.StartTime;
            workingDayTo.ItemsSource = ClassHelpers.GenerateListOfHours(new TimeSpan(7, 15, 0), new TimeSpan(20, 0, 0));
            workingDayTo.SelectedItem = lastSelectedTerm.EndTime;
        }

        private void CheckBoxChangeDay_Checked(object sender, RoutedEventArgs e)
        {
            if (CurrentMonthDataGrid.SelectedItem == null)
            {
                MessageBox.Show("To change the date you must select the day");
                checkBoxChangeDay.IsChecked = false;
                return;
            }
            if (workingDay.IsChecked == false)
            {
                MessageBox.Show("You cannot change the date of a non-working day");
                checkBoxChangeDay.IsChecked = false;
                return;
            }
            availableDates.IsEnabled = true;
            availableDates.ItemsSource = ListOfAvaiableDates();
        }

        private void CheckBoxChange_Unchecked(object sender, RoutedEventArgs e)
        {
            availableDates.IsEnabled = false;
            availableDates.ItemsSource = null;
        }

        private void CurrentMonthDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            workingDay.IsEnabled = true;
            ClassTerm term = (ClassTerm)CurrentMonthDataGrid.SelectedItem;
            if (term == null)
            {
                if (lastSelectedTerm.IsWorkingDay == true)
                    workingDay.IsChecked = true;
                else
                    workingDay.IsChecked = false;
            }
            else if (term.IsWorkingDay == true)
                workingDay.IsChecked = true;
            else
                workingDay.IsChecked = false;
        }

        private void CurrentMonthDataGrid_LostFocus(object sender, RoutedEventArgs e)
        {
            ClassTerm term = (ClassTerm)CurrentMonthDataGrid.SelectedItem;
            RefreshLastSelectedItems(term);
        }

        private void RefreshLastSelectedItems(ClassTerm term)
        {
            lastSelectedTerm = term;
            lastSelectedIndex = CurrentMonthDataGrid.SelectedIndex;
        }

        public void RefreshDataGrid()
        {
            CurrentMonthDataGrid.ItemsSource = null;
            CurrentMonthDataGrid.ItemsSource = ListOfTerms;
            CurrentMonthDataGrid.SelectedIndex = lastSelectedIndex;
        }

        public void RefreshList()
        {
            ListOfTerms = ClassSqlCalendar.GetListOfWorkingDayInCurrentMonth(ClassLoggedDoctor.Doctor_Id);
        }

        private List<ClassCalendarDay> ListOfOriginalDays()
        {
            ClassCalendar calendar = GetCalendarForCurrentDate();
            List<ClassCalendarDay> orignalDays = ClassSqlCalendar.ListOfCalendarDays(calendar.CalendarId);
            return orignalDays;
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

        private void availableDates_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (availableDates.SelectedItem != null)
            {
                ClassTerm term = (ClassTerm)CurrentMonthDataGrid.SelectedItem;
                RefreshLastSelectedItems(term);

                ClassSqlCalendar.UpdateTerm(((ClassCalendarDay)availableDates.SelectedItem).CalendarDayId, ((ClassCalendarDay)availableDates.SelectedItem).Date, lastSelectedTerm.TermId);

                CurrentMonthDataGrid.ItemsSource = ClassSqlCalendar.GetListOfWorkingDayInCurrentMonth(ClassLoggedDoctor.Doctor_Id);
                CurrentMonthDataGrid.SelectedIndex = lastSelectedIndex;

                checkBoxChangeDay.IsChecked = false;
            }

        }

        private void acceptChanges_Click(object sender, RoutedEventArgs e)
        {
            foreach (ClassTerm term in ListOfTerms)
            {
                if (term.IsWorkingDay == false)
                {
                    ClassSqlCalendar.DeleteTerm(term.TermId);
                }
            }
            RefreshList();
            RefreshDataGrid();
            CurrentMonthDataGrid.SelectedIndex = 0;
        }
    }
}
