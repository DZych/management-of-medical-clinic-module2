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
    /// Logika interakcji dla klasy WindowDoctorHistoryOfVisits.xaml
    /// </summary>
    public partial class WindowDoctorHistoryOfVisits : Page
    {
        public WindowDoctorHistoryOfVisits()
        {
            InitializeComponent();
        }

        private void SearchVisitsHistory_Click(object sender, RoutedEventArgs e)
        {
            WindowDoctorSearchVisits searchVisits = new WindowDoctorSearchVisits();
            searchVisits.ShowDialog();
        }

        private void ShowDetails_Click(object sender, RoutedEventArgs e)
        {
            WindowDoctorHistoryOfVisitsDetails windowDoctorHistoryOfVisitsDetails = new WindowDoctorHistoryOfVisitsDetails();
            windowDoctorHistoryOfVisitsDetails.ShowDialog();
        }
    }
}
