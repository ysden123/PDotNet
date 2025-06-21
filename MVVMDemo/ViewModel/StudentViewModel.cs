using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using static MVVMDemo.Model.StudentModel;

namespace MVVMDemo.ViewModel
{
    internal class StudentViewModel
    {
        public ObservableCollection<Student>? Students
        {
            get;
            set;
        }

        public void LoadStudents()
        {
            ObservableCollection<Student> students =
            [
                new Student { FirstName = "Mark", LastName = "Allain" },
                new Student { FirstName = "Allen", LastName = "Brown" },
                new Student { FirstName = "Linda", LastName = "Hamerski" },
            ];

            Students = students;
        }

        public void AddStudent(string firstName, string lastName)
        {
            Students?.Add(new Student { FirstName = firstName, LastName = lastName });
        }
    }
}
