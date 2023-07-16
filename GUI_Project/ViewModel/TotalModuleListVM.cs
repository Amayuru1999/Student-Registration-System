using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.ViewModel
{
    public partial class TotalModuleListVM:ObservableObject
    {
        public ObservableCollection<Module> Subjects { get;  set; }

        public void LoadPerson() 
        { 
            using(var db= new DataBaseContext())
            {
                var list = db.Modules.ToList();
                Subjects = new ObservableCollection<Module>(list);
            }
        }
        public TotalModuleListVM()
        {
            LoadPerson();
        }

    }
}
