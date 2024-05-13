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
    }
}