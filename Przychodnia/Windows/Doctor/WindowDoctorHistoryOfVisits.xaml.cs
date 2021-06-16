using Przychodnia.Class.Calendar;
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
        public static bool byName;
        public static string lastSearchedName;
        public static bool bySurname;
        public static string lastSearchedSurname;
        public static bool byPESEL;
        public static string lastSearchedPESEL;
        public static DateTime dateFrom;
        public static DateTime dateTo;
        public static bool myVisits;

        public WindowDoctorHistoryOfVisits()
        {
            InitializeComponent();
            HistoryOfVisits.ItemsSource = ClassSqlAppointment.GetAllAppoitments();
            HistoryOfVisits.SelectedIndex = 0;
        }

        private void SearchVisitsHistory_Click(object sender, RoutedEventArgs e)
        {
            WindowDoctorSearchVisits searchVisits = new WindowDoctorSearchVisits(ClassSqlAppointment.GetAllAppoitments());
            searchVisits.ShowDialog();
            HistoryOfVisits.ItemsSource = searchVisits.RefreshDataGrid();
        }

        private void ShowDetails_Click(object sender, RoutedEventArgs e)
        {
            if (HistoryOfVisits.SelectedItem != null)
            {
                ClassAppointment appointment = (ClassAppointment)HistoryOfVisits.SelectedItem;

                WindowDoctorHistoryOfVisitsDetails windowDoctorHistoryOfVisitsDetails = new WindowDoctorHistoryOfVisitsDetails(appointment.Patient.Name, appointment.Patient.Surname, appointment.Patient.PersonalIdentityNumber, appointment.Patient.PhoneNumber, appointment.Topic, appointment.Description);

                windowDoctorHistoryOfVisitsDetails.Show();
            }
            else
            {
                MessageBox.Show("You must choose an appointment");
            }

        }
    }
}
