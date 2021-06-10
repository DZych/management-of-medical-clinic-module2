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
            Visits.ItemsSource = ClassSqlAppointment.AppointmentsForDataGrid(((ClassTerm)DateVisitComboBox.SelectedItem).Date);

        }

        private void ChangeData_Click(object sender, RoutedEventArgs e)
        {
            ResultOfVisit.IsReadOnly = true;
            ConfirmResult.Visibility = Visibility.Hidden;
            if ((bool)ChangeData.IsChecked)
            {
                ResultOfVisit.IsReadOnly = false;
                ConfirmResult.Visibility =Visibility.Visible;
                TopicResult.IsReadOnly = false;
                
            }

        }

        private void ConfirmResult_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Visits.ItemsSource = ClassSqlAppointment.AppointmentsForDataGrid(((ClassTerm)DateVisitComboBox.SelectedItem).Date);
        }

        private void Vistis_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Visits.SelectedItem != null)
            {
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
                    NamePatient.Text = appointment.PatientName;
                    SurnamePatient.Text = appointment.PatientSurname;
                    PESELpatient.Text = appointment.NrPesel;
                    TopicResult.Text = historyAppointment.Topic;
                    ResultOfVisit.Text = historyAppointment.Add_description;



            }



        }
    }
}
#endregion