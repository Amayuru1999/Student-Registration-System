using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.ViewModel
{
    public partial class UpdateStudentDetailsVM : ObservableObject
    {
        [ObservableProperty]
        public string firstName;
        [ObservableProperty]
        public string lastName;


        [ObservableProperty]
        public int year;

        [ObservableProperty]
        ObservableCollection<StudentDetails> studentDetails;



        [RelayCommand]
        public void InsertStudent()
        {
            StudentDetails s = new StudentDetails()
            {
                FirstName = FirstName,
                LastName = LastName,
                Year = Year

            };
            using (var db = new DataBaseContext())
            {
                db.StudentDetailsFor.Add(s);
                db.SaveChanges();
            }
        }
    }
}
