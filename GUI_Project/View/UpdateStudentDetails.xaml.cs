using GUI_Project.ViewModel;
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

namespace GUI_Project.View
{
    /// <summary>
    /// Interaction logic for UpdateStudentDetails.xaml
    /// </summary>
    public partial class UpdateStudentDetails : Window
    {
        public UpdateStudentDetails()
        {
            DataContext = new UpdateStudentDetailsVM();

            InitializeComponent();
        }
    }
}
