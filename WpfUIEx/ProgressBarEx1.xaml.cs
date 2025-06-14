using System.Windows;
using System.Windows.Controls;

namespace WpfUIEx
{
    /// <summary>
    /// Interaction logic for ProgressBarEx1.xaml
    /// <br/>
    /// The code for a lengthy process is within the user control class.
    /// </summary>
    public partial class ProgressBarEx1 : UserControl
    {
        public ProgressBarEx1()
        {
            InitializeComponent();
        }

        private void StartProgress_Click(object sender, RoutedEventArgs e)
        {
            var thread = new Thread(new ThreadStart(Process));
            thread.Start();
        }

        private void Process()
        {
            this.Dispatcher.Invoke(new Action(() =>
            {
                ProgressBar.Minimum = 0;
                ProgressBar.Maximum = 111;
                StartProgress.IsEnabled = false;
            }
            ));

            for (int i = 0; i <= 111; ++i)
            {
                Thread.Sleep(50);
                this.Dispatcher.Invoke(new Action(() => { ProgressBar.Value = i; }
                ));
            }

            this.Dispatcher.Invoke(new Action(() =>
            {
                StartProgress.IsEnabled = true;
            }
            ));
        }
    }
}
