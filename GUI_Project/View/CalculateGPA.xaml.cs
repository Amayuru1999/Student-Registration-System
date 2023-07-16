using System;
using System.Windows;
using System.Windows.Controls;

namespace GUI_Project.View
{
    public partial class CalculateGPA : UserControl
    {
        public CalculateGPA()
        {
            InitializeComponent();
        }

        private void AddModuleBtn_Click(object sender, RoutedEventArgs e)
        {
            // Calculate the GPA and display it in the GPA TextBox
            var viewModel = (ViewModel.CalculateGPAVM)DataContext;
            viewModel.CalculateGPA();

            // Access the GPA value from the view model
            var gpa = viewModel.GPA;

            // Find the TextBox control by its name
            var gpaTextBox = (TextBox)FindName("YourGpaTextBox"); // Replace 'YourGpaTextBox' with the actual name of the TextBox control

            // Update the Text property of the TextBox with the calculated GPA
            gpaTextBox.Text = gpa.ToString();
        }
    }
}
