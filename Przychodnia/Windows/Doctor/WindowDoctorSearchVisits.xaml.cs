using Przychodnia.Class.Calendar;
using Przychodnia.Class.Doctor;
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
using System.Windows.Shapes;

namespace Przychodnia.Windows.Doctor
{
    /// <summary>
    /// Logika interakcji dla klasy WindowDoctorSearchVisits.xaml
    /// </summary>
    public partial class WindowDoctorSearchVisits : Window
    {

        #region Create lists for searching process
        List<ClassAppointment> listOfOriginalAppointments = new List<ClassAppointment>();
        List<ClassAppointment> listOfFinalAppointments = new List<ClassAppointment>();

        List<ClassAppointment> listOfFirstStageSortingAppointments = new List<ClassAppointment>();
        List<ClassAppointment> listOfSecondStageSortingAppointments = new List<ClassAppointment>();
        List<ClassAppointment> listOfThirdStageSortingAppointments = new List<ClassAppointment>();
        #endregion
        public WindowDoctorSearchVisits()
        {
            InitializeComponent();
        }
        public WindowDoctorSearchVisits(List<ClassAppointment> listOfAppointments)
        {
            InitializeComponent();


            listOfOriginalAppointments = listOfAppointments;

            #region Set last selected options

            ByName.IsChecked = WindowDoctorHistoryOfVisits.byName;
            NamePatient.Text = WindowDoctorHistoryOfVisits.lastSearchedName;
            BySurname.IsChecked = WindowDoctorHistoryOfVisits.bySurname;
            SurnamePatient.Text = WindowDoctorHistoryOfVisits.lastSearchedSurname;
            ByPeselNumber.IsChecked = WindowDoctorHistoryOfVisits.byPESEL;
            PeselNumber.Text = WindowDoctorHistoryOfVisits.lastSearchedPESEL;

            if (WindowDoctorHistoryOfVisits.dateFrom != new DateTime(0001, 01, 01))
                DatePickFrom.SelectedDate = WindowDoctorHistoryOfVisits.dateFrom;
            if (WindowDoctorHistoryOfVisits.dateFrom != new DateTime(0001, 01, 01))
                DatePickTo.SelectedDate = WindowDoctorHistoryOfVisits.dateTo;

            MyVisits.IsChecked = WindowDoctorHistoryOfVisits.myVisits;

            #endregion
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

            #region Sorting

            #region First stage of sorting - name, surname and PESEL

            if (!String.IsNullOrWhiteSpace(NamePatient.Text))
            {
                foreach (ClassAppointment appointment in listOfOriginalAppointments)
                {
                    if (appointment.Patient.Name == NamePatient.Text)
                        listOfFirstStageSortingAppointments.Add(appointment);
                }
            }

            if (!String.IsNullOrWhiteSpace(SurnamePatient.Text))
            {
                foreach (ClassAppointment appointment in listOfOriginalAppointments)
                {
                    if (appointment.Patient.Surname == SurnamePatient.Text)
                        listOfFirstStageSortingAppointments.Add(appointment);
                }
            }

            if (!String.IsNullOrWhiteSpace(PeselNumber.Text))
            {
                foreach (ClassAppointment appointment in listOfOriginalAppointments)
                {
                    if (appointment.Patient.PersonalIdentityNumber == PeselNumber.Text)
                        listOfFirstStageSortingAppointments.Add(appointment);
                }
            }
            #endregion

            #region Second stage of sorting - date

            if (listOfFirstStageSortingAppointments.Count == 0)
            {
                if (DatePickFrom.SelectedDate == null && DatePickTo.SelectedDate == null)
                {
                    listOfSecondStageSortingAppointments = listOfFirstStageSortingAppointments;
                }
                else if(!String.IsNullOrWhiteSpace(NamePatient.Text) || !String.IsNullOrWhiteSpace(SurnamePatient.Text) || !String.IsNullOrWhiteSpace(PeselNumber.Text))
                {
                    SecondStageSorting(listOfFirstStageSortingAppointments);
                }
                else
                {
                    SecondStageSorting(listOfOriginalAppointments);
                }
            }
            else
            {
                SecondStageSorting(listOfFirstStageSortingAppointments);
            }
            #endregion

            #region Third stage of sorting - my visits

            if (MyVisits.IsChecked == true)
            {
                if((!String.IsNullOrWhiteSpace(NamePatient.Text) || !String.IsNullOrWhiteSpace(SurnamePatient.Text) || !String.IsNullOrWhiteSpace(PeselNumber.Text) || DatePickFrom.SelectedDate != null || DatePickTo.SelectedDate != null)){
                    foreach (ClassAppointment appointment in listOfSecondStageSortingAppointments)
                    {
                        if (appointment.Doctor.Doctor_id == ClassLoggedDoctor.Doctor_Id)
                        {
                            listOfThirdStageSortingAppointments.Add(appointment);
                        }
                    }
                }
                else
                {
                    foreach (ClassAppointment appointment in listOfOriginalAppointments)
                    {
                        if (appointment.Doctor.Doctor_id == ClassLoggedDoctor.Doctor_Id)
                        {
                            listOfThirdStageSortingAppointments.Add(appointment);
                        }
                    }
                }

                // Remove all duplicates
                listOfFinalAppointments = listOfThirdStageSortingAppointments.Distinct().ToList();
            }
            else
            {
                // Remove all duplicates
                listOfFinalAppointments = listOfSecondStageSortingAppointments.Distinct().ToList();
            }
            #endregion

            #endregion

            #region Save dates for next loading
            WindowDoctorHistoryOfVisits.byName = (bool)ByName.IsChecked;
            WindowDoctorHistoryOfVisits.lastSearchedName = NamePatient.Text;
            WindowDoctorHistoryOfVisits.bySurname = (bool)BySurname.IsChecked;
            WindowDoctorHistoryOfVisits.lastSearchedSurname = SurnamePatient.Text;
            WindowDoctorHistoryOfVisits.byPESEL = (bool)ByPeselNumber.IsChecked;
            WindowDoctorHistoryOfVisits.lastSearchedPESEL = PeselNumber.Text;
            WindowDoctorHistoryOfVisits.myVisits = (bool)MyVisits.IsChecked;
            WindowDoctorHistoryOfVisits.dateFrom = DatePickFrom.SelectedDate.GetValueOrDefault();
            WindowDoctorHistoryOfVisits.dateTo = DatePickTo.SelectedDate.GetValueOrDefault();
            #endregion

            this.Close();
        }

        private void SecondStageSorting(List<ClassAppointment> appointments)
        {
            if (DatePickFrom.SelectedDate != null && DatePickTo.SelectedDate != null)
            {
                foreach (ClassAppointment appointment in appointments)
                {
                    if (appointment.Term.Date >= DatePickFrom.SelectedDate && appointment.Term.Date <= DatePickTo.SelectedDate)
                        listOfSecondStageSortingAppointments.Add(appointment);
                }
            }
            else if (DatePickFrom.SelectedDate != null && DatePickTo.SelectedDate == null)
            {
                foreach (ClassAppointment appointment in appointments)
                {
                    if (appointment.Term.Date >= DatePickFrom.SelectedDate)
                        listOfSecondStageSortingAppointments.Add(appointment);
                }
            }
            else if (DatePickFrom.SelectedDate == null && DatePickTo.SelectedDate != null)
            {
                foreach (ClassAppointment appointment in appointments)
                {
                    if (appointment.Term.Date <= DatePickTo.SelectedDate)
                        listOfSecondStageSortingAppointments.Add(appointment);
                }
            }
            else if (DatePickFrom.SelectedDate == null && DatePickTo.SelectedDate == null)
            {
                listOfSecondStageSortingAppointments = appointments;
            }
        }

        public List<ClassAppointment> RefreshDataGrid()
        {
            if (ByName.IsChecked == false && BySurname.IsChecked == false && ByPeselNumber.IsChecked == false && DatePickFrom.SelectedDate == null && DatePickTo.SelectedDate == null && MyVisits.IsChecked == false)
            {
                return listOfOriginalAppointments;
            }
            else
            {
                return listOfFinalAppointments;
            }
        }

        private void ByName_Checked(object sender, RoutedEventArgs e)
        {
            LabelNamePatient.Opacity = new double();
            LabelNamePatient.Opacity = 1;
            NamePatient.IsEnabled = true;
        }

        private void ByName_Unchecked(object sender, RoutedEventArgs e)
        {
            LabelNamePatient.Opacity = new double();
            LabelNamePatient.Opacity = 0.5;
            NamePatient.IsEnabled = false;
            NamePatient.Text = "";
        }

        private void ByPeselNumber_Checked(object sender, RoutedEventArgs e)
        {
            LabelPeselNumber.Opacity = new double();
            LabelPeselNumber.Opacity = 1;
            PeselNumber.IsEnabled = true;
        }

        private void ByPeselNumber_Unchecked(object sender, RoutedEventArgs e)
        {
            LabelPeselNumber.Opacity = 0.5;
            PeselNumber.IsEnabled = false;
            PeselNumber.Text = "";
        }

        private void BySurname_Checked(object sender, RoutedEventArgs e)
        {
            LabelSurnamePatient.Opacity = new double();
            LabelSurnamePatient.Opacity = 1;
            SurnamePatient.IsEnabled = true;
        }

        private void BySurname_Unchecked(object sender, RoutedEventArgs e)
        {
            LabelSurnamePatient.Opacity = new double();
            LabelSurnamePatient.Opacity = 0.5;
            SurnamePatient.IsEnabled = false;
            SurnamePatient.Text = "";
        }

        private void MyVisits_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void MyVisits_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
