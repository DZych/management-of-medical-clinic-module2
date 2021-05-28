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
        }

        #region Variables
        List<ClassTerm> ListOfTerms = ClassSqlCalendar.GetListOfWorkingDayInCurrentMonth(ClassLoggedDoctor.Doctor_Id);
        ClassTerm lastSelectedTerm = null;
        int lastSelectedIndex = 0;
        #endregion

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowDoctorEditCalendarAdd windowDoctorEditCalendarAdd = new WindowDoctorEditCalendarAdd();
            windowDoctorEditCalendarAdd.ShowDialog();
        }

        private void workingDayFrom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(workingDayFrom.SelectedItem != null)
            {
                lastSelectedTerm.StartTime = (TimeSpan)workingDayFrom.SelectedItem;
                ListOfTerms.RemoveAt(CurrentMonthDataGrid.SelectedIndex);
                ListOfTerms.Insert(CurrentMonthDataGrid.SelectedIndex, lastSelectedTerm);

                RefreshDataGrid();

                if (workingDayFrom.SelectedIndex == workingDayFrom.Items.Count - 1)
                {
                    workingDayTo.ItemsSource = ClassHelpers.GenerateListOfHours((TimeSpan)workingDayFrom.Items[workingDayFrom.SelectedIndex], lastSelectedTerm.EndTime + new TimeSpan(0, 15, 0));
                }
                else
                {
                    workingDayTo.ItemsSource = ClassHelpers.GenerateListOfHours((TimeSpan)workingDayFrom.Items[workingDayFrom.SelectedIndex + 1], lastSelectedTerm.EndTime);
                }

                if ((TimeSpan)workingDayFrom.SelectedItem > lastSelectedTerm.EndTime)
                {
                    workingDayTo.ItemsSource = ClassHelpers.GenerateListOfHours((TimeSpan)workingDayFrom.Items[workingDayFrom.SelectedIndex + 1], ClassHelpers.GenerateListOfHours(new TimeSpan(7, 15, 0), new TimeSpan(20, 00, 0))[lastSelectedIndex]);
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

            term.IsWorkingDay = true;
            ListOfTerms.RemoveAt(CurrentMonthDataGrid.SelectedIndex);
            ListOfTerms.Insert(CurrentMonthDataGrid.SelectedIndex, term);

            RefreshDataGrid();

            workingDayFrom.ItemsSource = ClassHelpers.GenerateListOfHours(new TimeSpan(7, 0, 0), new TimeSpan(19, 45, 0));
            workingDayFrom.SelectedItem = lastSelectedTerm.StartTime;
            workingDayTo.ItemsSource = ClassHelpers.GenerateListOfHours(new TimeSpan(7, 15, 0), new TimeSpan(20, 0, 0));
            workingDayTo.SelectedItem = lastSelectedTerm.StartTime;
        }

        private void CheckBoxChangeDay_Checked(object sender, RoutedEventArgs e)
        {
            availableDates.IsEnabled = true;
        }

        private void CheckBoxChange_Unchecked(object sender, RoutedEventArgs e)
        {
            availableDates.IsEnabled = false;
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

        private void RefreshDataGrid()
        {
            CurrentMonthDataGrid.ItemsSource = null;
            CurrentMonthDataGrid.ItemsSource = ListOfTerms;
            CurrentMonthDataGrid.SelectedIndex = lastSelectedIndex;
        }

    }
}
