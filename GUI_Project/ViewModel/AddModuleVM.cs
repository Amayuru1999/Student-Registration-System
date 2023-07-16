using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GUI_Project.Model;
namespace GUI_Project.ViewModel

{
    public partial class AddModuleVM:ObservableObject
    {
        [ObservableProperty]
        public string moduleCode;
        [ObservableProperty]
        public string moduleName;
        [ObservableProperty]
        public string moduleCoordinator;

        [ObservableProperty]
        ObservableCollection<Module> modules;


        [RelayCommand]
        public void InsertModule()
        {
            Module m=new Module()
            {
                ModuleCode = ModuleCode,
                ModuleName = ModuleName,
                ModuleCoordinator = ModuleCoordinator
            };
            using (var db=new DataBaseContext())
            {
                db.Modules.Add(m);
                db.SaveChanges();
            }
        }
    }
}
