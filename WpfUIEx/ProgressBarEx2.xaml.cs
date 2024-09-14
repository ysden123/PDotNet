using System.Windows;
using System.Windows.Controls;

namespace WpfUIEx
{
    /// <summary>
    /// Interaction logic for ProgressBarEx2.xaml
    /// </summary>
    public partial class ProgressBarEx2 : UserControl
    {
        public ProgressBarEx2()
        {
            InitializeComponent();
        }

        private void StartProgress_Click(object sender, RoutedEventArgs e)
        {
            var longProcess = new LongProcess1(init, update);

            longProcess.Start();
        }

        private void init(int start, int finish)
        {
            this.Dispatcher.Invoke(new Action(() =>
            {
                ProgressBar.Minimum = start;
                ProgressBar.Maximum = finish;
                StartProgress.IsEnabled = false;
            }
            ));
        }

        private void update(int value)
        {
            this.Dispatcher.Invoke(new Action(() =>
            {
                ProgressBar.Value = value;
            }
           ));
        }
    }
}
