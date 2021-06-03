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
    /// Logika interakcji dla klasy WindowDoctorVisits.xaml
    /// </summary>
    public partial class WindowDoctorVisits : Page
    {
        public WindowDoctorVisits()
        {
            InitializeComponent();
            
        }

        private void ChangeData_Click(object sender, RoutedEventArgs e)
        {
            ResultOfVisit.IsReadOnly = true;
            ConfirmResult.Visibility = Visibility.Hidden;
            if ((bool)ChangeData.IsChecked)
            {
                ResultOfVisit.IsReadOnly = false;
                ConfirmResult.Visibility =Visibility.Visible;
                
            }

        }

        private void ConfirmResult_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
