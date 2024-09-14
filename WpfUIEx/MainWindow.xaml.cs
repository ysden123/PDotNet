using System.Windows;

namespace WpfUIEx
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

        private void ProgressBar1Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new ProgressBarEx1();
        }

        private void ProgressBar2Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new ProgressBarEx2();
        }

        private void GridEx1Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new GridEx01();
        }
    }
}