using System.Windows;

namespace WpfStyleEx
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

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The button 1 clicked");
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The button 2 clicked");
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The button 3 clicked");
        }
    }
}