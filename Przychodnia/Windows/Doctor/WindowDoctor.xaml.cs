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
using System.Windows.Shapes;

namespace Przychodnia.Windows.Doctor
{
    /// <summary>
    /// Logika interakcji dla klasy WindowDoctor.xaml
    /// </summary>
    public partial class WindowDoctor : Window
    {
        public WindowDoctor()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void TabItem_Logout(Object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                WindowLogin windowLogin = new WindowLogin();
                windowLogin.Show();
                this.Close();
            }
            else
            {
                this.TabControlMain.SelectedIndex = 0;
                return;
            }
        } 
    }
}
