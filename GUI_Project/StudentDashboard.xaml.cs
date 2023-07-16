using MaterialDesignThemes.Wpf;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Reflection.Emit;
using System.Data.SQLite;
using System.Data;
using GUI_Project.View;

namespace GUI_Project
{
    /// <summary>
    /// Interaction logic for StudentDashboard.xaml
    /// </summary>
    public partial class StudentDashboard : Window
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            StudentWindow newWindow = new StudentWindow();

            // Show the new window
            this.Close();
            newWindow.Show();
        }

        private void LoadWindow<T>(T window) where T : Window
        {
            // Close the current window
            this.Close();

            // Show the new window
            window.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ModuleRegistration newWindow = new ModuleRegistration();
            LoadWindow(newWindow);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UpdateStudentDetails newWindow = new UpdateStudentDetails();
            LoadWindow(newWindow);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CalculateGPAStudent newWindow = new CalculateGPAStudent();
            LoadWindow(newWindow);
        }
    }
}
