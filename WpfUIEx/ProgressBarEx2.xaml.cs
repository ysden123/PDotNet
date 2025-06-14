using Serilog;
using System.Windows;
using System.Windows.Controls;

namespace WpfUIEx
{
    /// <summary>
    /// Interaction logic for ProgressBarEx2.xaml
    /// <br/>
    /// The code for a lengthy process is outside the user control class.
    /// </summary>
    public partial class ProgressBarEx2 : UserControl
    {
        private readonly ILogger _logger;
        public ProgressBarEx2()
        {
            InitializeComponent();
            _logger = Log.ForContext<ProgressBarEx2>();
        }

        private void StartProgress_Click(object sender, RoutedEventArgs e)
        {
            _logger.Debug("==>StartProgress_Click");
            var longProcess = new LongProcess1(Init, Update);

            longProcess.Start();
            _logger.Debug("<==StartProgress_Click");
        }

        private void Init(int start, int finish)
        {
            _logger.Debug("==>Init({start}, {finish})", start, finish);
            this.Dispatcher.Invoke(new Action(() =>
            {
                ProgressBar.Minimum = start;
                ProgressBar.Maximum = finish;
                StartProgress.IsEnabled = false;
            }
            ));
        }

        private void Update(int value)
        {
            _logger.Debug("==>Update");
            this.Dispatcher.Invoke(new Action(() =>
            {
                _logger.Debug("in update value={value}", value);
                ProgressBar.Value = value;
            }
           ));
        }
    }
}
