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
