using System.ComponentModel;

namespace MVVMDemo.Model
{
    internal class StudentModel
    {
        public class Student : INotifyPropertyChanged
        {
            private string? firstName;
            private string? lastName;

            public event PropertyChangedEventHandler? PropertyChanged = default;

            public string? FirstName
            {
                get => firstName;

                set
                {
                    if (firstName != value)
                    {
                        firstName = value;
                        RaisePropertyChanged("FirstName");
                        RaisePropertyChanged("FullName");
                    }
                }
            }

            public string? LastName
            {
                get => lastName;

                set
                {
                    if (lastName != value)
                    {
                        lastName = value;
                        RaisePropertyChanged("LastName");
                        RaisePropertyChanged("FullName");
                    }
                }
            }

            public string FullName
            {
                get
                {
                    return firstName + " " + lastName;
                }
            }

            private void RaisePropertyChanged(string property)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(property));
                }
            }
        }
    }
}
