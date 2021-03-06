using System;
using Przychodnia.Class.Calendar;
using Przychodnia.Class.DictionariesHanding;
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
    /// Logika interakcji dla klasy WindowDoctorVisits.xaml
    /// </summary>
    public partial class WindowDoctorVisits : Page
    {


        public WindowDoctorVisits()
        {
            InitializeComponent();
            #region Load Date to Combo
            try
            {
                DateVisitComboBox.ItemsSource = ClassSqlAppointment.AppointmentsDateForCombobox();

                DateVisitComboBox.SelectedIndex = DateVisitComboBox.Items.Count - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Visits.ItemsSource = null;
            if(DateVisitComboBox.Items.Count != 0)
            {
                Visits.ItemsSource = ClassSqlAppointment.AppointmentsForDataGrid(((ClassTerm)DateVisitComboBox.SelectedItem).Date);
            }
            
            

        }

        ClassAppointment lastSelectedAppointmentHistoryVistis = null;
        ClassAppointment lastSelectedAppointmentVisits = null;

        int lastSelectedIndexHistoryVistis = -1;
        int lastSelectedIndexVisits = -1;

        private void ChangeData_Click(object sender, RoutedEventArgs e)
        {
            ResultOfVisit.IsReadOnly = true;
            ConfirmResult.Visibility = Visibility.Hidden;
            if ((bool)ChangeData.IsChecked)
            {
                ResultOfVisit.IsReadOnly = false;
                ConfirmResult.Visibility = Visibility.Visible;
                TopicResult.IsReadOnly = false;

            }

        }

        private void ConfirmResult_Click(object sender, RoutedEventArgs e)
        {
            if(lastSelectedAppointmentHistoryVistis != null)
            {
                ClassSqlAppointment.UpdateAppointment(lastSelectedAppointmentHistoryVistis.AppointmendtId, ResultOfVisit.Text, TopicResult.Text);
                Refresh();
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Visits.ItemsSource = ClassSqlAppointment.AppointmentsForDataGrid(((ClassTerm)DateVisitComboBox.SelectedItem).Date);
        }

        private void Vistis_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Visits.SelectedItem != null)
            {
                lastSelectedAppointmentVisits = (ClassAppointment)Visits.SelectedItem;
                lastSelectedIndexVisits = Visits.SelectedIndex;

                HistoryofPacient.ItemsSource = null;
                HistoryofPacient.ItemsSource = ClassSqlAppointment.GetAllApoitmentsForPatien((ClassAppointment)Visits.SelectedItem);
            }
        }

        private void HistoryofPacient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HistoryofPacient.SelectedItem != null && Visits.SelectedItem != null)
            {
                ClassAppointment historyAppointment = (ClassAppointment)HistoryofPacient.SelectedItem;
                ClassAppointment appointment = (ClassAppointment)Visits.SelectedItem;
                NamePatient.Text = appointment.Patient.Name;
                SurnamePatient.Text = appointment.Patient.Surname;
                PESELpatient.Text = appointment.Patient.PersonalIdentityNumber;
                TopicResult.Text = historyAppointment.Topic;
                ResultOfVisit.Text = historyAppointment.Description;

                lastSelectedAppointmentHistoryVistis = (ClassAppointment)HistoryofPacient.SelectedItem;
                lastSelectedIndexHistoryVistis = HistoryofPacient.SelectedIndex;
            }
        }

        private void Refresh()
        {
            Visits.ItemsSource = ClassSqlAppointment.AppointmentsForDataGrid(((ClassTerm)DateVisitComboBox.SelectedItem).Date);
            HistoryofPacient.ItemsSource = ClassSqlAppointment.GetAllApoitmentsForPatien(lastSelectedAppointmentHistoryVistis);

            Visits.SelectedIndex = lastSelectedIndexVisits;
            HistoryofPacient.SelectedIndex = lastSelectedIndexHistoryVistis;
        }
    }
}
#endregion