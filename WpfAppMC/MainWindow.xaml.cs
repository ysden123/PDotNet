using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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