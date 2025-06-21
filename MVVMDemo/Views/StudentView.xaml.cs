using MVVMDemo.ViewModel;
using System.Windows.Controls;

namespace MVVMDemo.Views
{
    /// <summary>
    /// Interaction logic for StudentView.xaml
    /// </summary>
    public partial class StudentView : UserControl
    {
        public StudentView()
        {
            InitializeComponent();
        }

        private void AddStudent_Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (DataContext != null)
            {
                StudentViewModel studentViewModel = (StudentViewModel)DataContext;
                studentViewModel?.AddStudent("new first name", "new last name");
            }
        }
    }
}
