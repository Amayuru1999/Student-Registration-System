using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUI_Project
{
    /// <summary>
    /// Interaction logic for AdministratorDashboard.xaml
    /// </summary>
    public partial class AdministratorDashboard : Window
    {
        public AdministratorDashboard()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            AdministratorWindow newWindow = new AdministratorWindow();

            // Show the new window
            this.Close();

            newWindow.Show();
        }
    }
}
