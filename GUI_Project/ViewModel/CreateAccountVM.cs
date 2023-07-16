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
    public partial class CreateAccountVM : ObservableObject
    {
        [ObservableProperty]
        public string name;
        [ObservableProperty]
        public string password;


        

        [ObservableProperty]
        ObservableCollection<Student> student;



        [RelayCommand]
        public void InsertStudentAccount()
        {
            Student s = new Student()
            {
                Name = Name,
                 Password=Password

            };
            using (var db = new DataBaseContext())
            
                db.Students.Add(s);
                db.SaveChanges();
            }
        }
    }

