using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Linq;

namespace GUI_Project.ViewModel
{
    public partial class RemoveStudentVM : ObservableObject
    {
        private string id;
        private string firstName;
        private string lastName;
        private int year;
        private ObservableCollection<StudentDetails> studentDetails;

        public string Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }

        public string FirstName
        {
            get => firstName;
            set => SetProperty(ref firstName, value);
        }

        public string LastName
        {
            get => lastName;
            set => SetProperty(ref lastName, value);
        }

        public int Year
        {
            get => year;
            set => SetProperty(ref year, value);
        }

        public ObservableCollection<StudentDetails> StudentDetails
        {
            get => studentDetails;
            set => SetProperty(ref studentDetails, value);
        }

        public RemoveStudentVM()
        {
            // Initialize the studentDetails collection
            studentDetails = new ObservableCollection<StudentDetails>();
        }

        [RelayCommand]
        public void RemoveStudent()
        {
            if (!string.IsNullOrEmpty(Id))
            {
                int studentId;
                if (int.TryParse(Id, out studentId))
                {
                    using (var db = new DataBaseContext())
                    {
                        // Find the student in the database by ID
                        var dbStudent = db.StudentDetailsFor.FirstOrDefault(s => s.Id == studentId);

                        if (dbStudent != null)
                        {
                            // Remove the student from the database
                            db.StudentDetailsFor.Remove(dbStudent);
                            db.SaveChanges();
                        }

                        // Find the student in the collection
                        var studentToRemove = studentDetails.FirstOrDefault(s => s.Id == studentId);

                        if (studentToRemove != null)
                        {
                            // Remove the student from the collection
                            studentDetails.Remove(studentToRemove);
                        }
                    }
                }
            }
        }
    }
}
