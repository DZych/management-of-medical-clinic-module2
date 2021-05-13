using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Przychodnia.Class.Doctor;
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
    /// Logika interakcji dla klasy WindowDoctorEditCalendar.xaml
    /// </summary>
    public partial class WindowDoctorEditCalendar : Page
    {
        public WindowDoctorEditCalendar()
        {
            InitializeComponent();

            ClassExample day1 = new ClassExample("01.05.21", "Tue", "07:00", "20:00"); CurrentMonthDataGrid.Items.Add(day1);
            ClassExample day2 = new ClassExample("02.05.21", "Wed", "07:00", "20:00"); CurrentMonthDataGrid.Items.Add(day2);
            ClassExample day3 = new ClassExample("03.05.21", "Thu", "07:00", "20:00"); CurrentMonthDataGrid.Items.Add(day3);
            ClassExample day4 = new ClassExample("04.05.21", "Fri", "07:00", "20:00"); CurrentMonthDataGrid.Items.Add(day4);
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowDoctorEditCalendarAdd windowDoctorEditCalendarAdd = new WindowDoctorEditCalendarAdd();
            windowDoctorEditCalendarAdd.ShowDialog();
        }

        private void CheckBoxWorkingDay_Click(object sender, RoutedEventArgs e)
        {
            workingDayFrom.IsEnabled = false;
            workingDayTo.IsEnabled = false;

            if ((bool)workingDay.IsChecked)
            {
                workingDayFrom.IsEnabled = true;
                workingDayTo.IsEnabled = true;
            }
        }

        private void CheckBoxChangeDay_Click(object sender, RoutedEventArgs e)
        {
            availableDates.IsEnabled = false;
            if ((bool)checkBoxChangeDay.IsChecked)
                availableDates.IsEnabled = true;
        }
    }
}
