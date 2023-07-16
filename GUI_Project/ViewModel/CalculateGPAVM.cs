using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace GUI_Project.ViewModel
{
    public partial class CalculateGPAVM : ObservableObject
    {
        private Dictionary<string, double> gradeWeights;

        private string module01Grade;
        private string module02Grade;
        private string module03Grade;
        private string module04Grade;
        private string module05Grade;
        private string module06Grade;

        public string Module01Grade
        {
            get => module01Grade;
            set => SetProperty(ref module01Grade, value);
        }

        public string Module02Grade
        {
            get => module02Grade;
            set => SetProperty(ref module02Grade, value);
        }

        public string Module03Grade
        {
            get => module03Grade;
            set => SetProperty(ref module03Grade, value);
        }

        public string Module04Grade
        {
            get => module04Grade;
            set => SetProperty(ref module04Grade, value);
        }

        public string Module05Grade
        {
            get => module05Grade;
            set => SetProperty(ref module05Grade, value);
        }

        public string Module06Grade
        {
            get => module06Grade;
            set => SetProperty(ref module06Grade, value);
        }

        public double GPA { get; private set; }

        public CalculateGPAVM()
        {
            // Initialize properties
            Module01Grade = string.Empty;
            Module02Grade = string.Empty;
            Module03Grade = string.Empty;
            Module04Grade = string.Empty;
            Module05Grade = string.Empty;
            Module06Grade = string.Empty;

            // Initialize grade weights
            gradeWeights = new Dictionary<string, double>
            {
                { "A+", 4.0 },
                { "A", 4.0 },
                { "A-", 3.7 },
                { "B+", 3.3 },
                { "B", 3.0 },
                { "B-", 2.7 },
                { "C+", 2.3 },
                { "C", 2.0 },
                { "C-", 1.7 },
                { "D+", 1.3 },
                { "D", 1.0 },
                { "F", 0.0 }
            };

            // Initialize command
            CalculateGPACommand = new RelayCommand(CalculateGPA);
        }

        public RelayCommand CalculateGPACommand { get; }

        public void CalculateGPA()
        {
            // Calculate the sum of the grade weights
            double sumOfWeights = GetGradeWeight(Module01Grade) +
                                  GetGradeWeight(Module02Grade) +
                                  GetGradeWeight(Module03Grade) +
                                  GetGradeWeight(Module04Grade) +
                                  GetGradeWeight(Module05Grade) +
                                  GetGradeWeight(Module06Grade);

            // Calculate the GPA
            GPA = sumOfWeights / 6;

            // Round the GPA to two decimal places
            GPA = Math.Round(GPA, 2);

            // Notify the UI that the GPA property has changed
            OnPropertyChanged(nameof(GPA));
        }

        private double GetGradeWeight(string grade)
        {
            // Check if the grade exists in the gradeWeights dictionary
            if (gradeWeights.TryGetValue(grade, out double weight))
            {
                return weight;
            }

            return 0.0; // Return 0 if the grade is not found
        }

        private RelayCommand insertGPACommand;
        public ICommand InsertGPACommand => insertGPACommand ??= new RelayCommand(InsertGPA);

        private void InsertGPA()
        {
        }
    }
}
