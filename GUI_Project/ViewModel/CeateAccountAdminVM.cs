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
    public partial class CeateAccountAdminVM : ObservableObject
    {
        [ObservableProperty]
        public string name;
        [ObservableProperty]
        public string password;




        [ObservableProperty]
        ObservableCollection<Administrator> administrator;



        [RelayCommand]
        public void InsertStudentAccount()
        {
            Administrator s = new Administrator()
            {
                Name = Name,
                Password = Password

            };
            using (var db = new DataBaseContext())

                db.Administrators.Add(s);
            db.SaveChanges();
        }
    }
}

