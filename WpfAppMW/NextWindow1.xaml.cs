using System.Windows;

namespace WpfAppMW
{
    /// <summary>
    /// Interaction logic for NextWindow1.xaml
    /// </summary>
    public partial class NextWindow1 : Window
    {
        public NextWindow1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.t1.Text = "Button clicked";
        }
    }
}
