using GUI_Project.Utilities;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GUI_Project.ViewModel
{
     class NavigationVM:Utilities.ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand AddModuleCommand { get; set; }
        public ICommand AddStudentCommand { get; set; }
        public ICommand CalculateGPACommand { get; set; }
        public ICommand RemoveStudentCommand { get; set; }
        public ICommand TotalModuleListCommand { get; set; }
        public ICommand TotalStudentListCommand { get; set; }

        private void AddModule(object obj) => CurrentView = new AddModuleVM();
        private void AddStudent(object obj) => CurrentView = new AddStudentVM();
        private void CalculateGPA(object obj) => CurrentView = new CalculateGPAVM();
        
        private void RemoveStudent(object obj) => CurrentView = new RemoveStudentVM();
        private void TotalModuleList(object obj) => CurrentView = new TotalModuleListVM();
        private void TotalStudentList(object obj) => CurrentView = new TotalStudentListVM();

        public NavigationVM()
        {
            AddModuleCommand = new RelayCommand(AddModule);
            AddStudentCommand = new RelayCommand(AddStudent);
            CalculateGPACommand = new RelayCommand(CalculateGPA);
            
            RemoveStudentCommand=new RelayCommand(RemoveStudent);
            TotalModuleListCommand = new RelayCommand(TotalModuleList);
            TotalStudentListCommand = new RelayCommand(TotalStudentList);

            CurrentView = new AddModuleVM();
        }
    }
}
