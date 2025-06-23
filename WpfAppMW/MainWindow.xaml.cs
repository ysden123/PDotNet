using System.Windows;

namespace WpfAppMW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is the action 1");
        }

        private void MenuItem_Click2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is the action 2");

        }

        private void MenuItem_Close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void NextWindow1_Click(object sender, RoutedEventArgs e)
        {
            var nextWindow1 = new NextWindow1();
            nextWindow1.Owner = this;
            nextWindow1.ShowDialog();
        }

        private void SomeDialog_Click(object sender, RoutedEventArgs e)
        {
            var someDialogData = new SomeDialogData("Initial");
            var someDialog = new SomeDialog(someDialogData)
            {
                Owner = this
            };

            if (someDialog.ShowDialog() == true)
            {
                MessageBox.Show(someDialogData.T1);
            }else
            {
                MessageBox.Show("Not OK clicked");
            }
        }
    }
}