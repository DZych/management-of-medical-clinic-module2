using Przychodnia.Class.Calendar;
using Przychodnia.Class.Doctor;
using System;
using System.Collections.Generic;
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

            ClassExample day1 = new ClassExample("01.06.21", "Tue", "07:00", "20:00"); CurrentMonthDataGrid.Items.Add(day1);
            ClassExample day2 = new ClassExample("02.06.21", "Wed", "07:00", "20:00"); CurrentMonthDataGrid.Items.Add(day2);
            ClassExample day3 = new ClassExample("03.06.21", "Thu", "07:00", "20:00"); CurrentMonthDataGrid.Items.Add(day3);
            ClassExample day4 = new ClassExample("04.06.21", "Fri", "07:00", "20:00"); CurrentMonthDataGrid.Items.Add(day4);

            ClassExample day5 = new ClassExample("01.05.21", "Mon", "07:00", "20:00"); PreviousMonthDataGrid.Items.Add(day5);
            ClassExample day6 = new ClassExample("02.05.21", "Tue", "07:00", "20:00"); PreviousMonthDataGrid.Items.Add(day6);
            ClassExample day7 = new ClassExample("03.05.21", "Wed", "07:00", "20:00"); PreviousMonthDataGrid.Items.Add(day7);
            ClassExample day8 = new ClassExample("04.05.21", "Thu", "07:00", "20:00"); PreviousMonthDataGrid.Items.Add(day8);
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
    }
}
