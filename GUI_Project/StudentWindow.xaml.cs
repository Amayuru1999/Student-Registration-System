//Theme Code ==================>>
using MaterialDesignThemes.Wpf;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
//=============================>>
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
using System.Windows.Navigation;

using System.Windows.Shapes;

namespace GUI_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        public StudentWindow()
        {
            InitializeComponent();
        }




        //Theme Code ========================>
        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();
        //===================================>

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void toggleTheme(object sender, RoutedEventArgs e)
        {
            //Theme Code ========================>
            ITheme theme = paletteHelper.GetTheme();
            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }

            paletteHelper.SetTheme(theme);
            //===================================>
        }

        private void exitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;
            if (CheckUsernameAndPassword(username, password))
            {
                StudentDashboard newWindow = new StudentDashboard();

                // Show the new window
                this.Close();
                newWindow.Show();
            }
            else
            {
                // The username and password are invalid
                
                    errorMessage.Content = "Incorrect username or password";
                    errorMessage.Visibility = Visibility.Visible;
                
               

            }
        }
        private bool CheckUsernameAndPassword(string name, string password)
        {
            using (var context = new DataBaseContext())
            {
                // Find a user in the database with the same username and password
                Student user = context.Students.FirstOrDefault(u => u.Name == name && u.Password == password);

                // If a user was found, the input is valid
                return user != null;
            }

        }


        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the new window
            MainWindow newWindow = new MainWindow();

            // Show the new window
            this.Close();

            newWindow.Show();
        }
    }
}
