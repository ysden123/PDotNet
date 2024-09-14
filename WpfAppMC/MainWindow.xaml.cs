using System.Windows;

namespace WpfAppMC
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

        private void MenuItemWindow1_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new UserWindowControl1();
        }

        private void MenuItemWindow2_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new UserWindowControl2();
        }
    }
}