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
    /// Logika interakcji dla klasy WindowDoctorHistoryOfVisitsDetails.xaml
    /// </summary>
    public partial class WindowDoctorHistoryOfVisitsDetails : Window
    {
        public WindowDoctorHistoryOfVisitsDetails()
        {
            InitializeComponent();
            
        }

        public WindowDoctorHistoryOfVisitsDetails(string name, string surname, string PESEL, string phone, string topic, string description)
        {
            InitializeComponent();
            DetailsName.Text = name;
            DetailsSurname.Text = surname;
            DetailsPesel.Text = PESEL;
            DetailsPhone.Text = phone;
            DetailsTopic.Text = topic;
            DetailsResultOfVisit.Text = description;
        }

        private void CloseDetailsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
