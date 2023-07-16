using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.ViewModel
{
    public partial class TotalStudentListVM: ObservableObject
    {
        public ObservableCollection<StudentDetails> Students { get;  set; }

        public void LoadPerson()
        {
            using (var db = new DataBaseContext())
            {
                var list = db.StudentDetailsFor.ToList();
                Students = new ObservableCollection<StudentDetails>(list);
            }
        }
        public TotalStudentListVM()
        {
            LoadPerson();
        }
    }
}
