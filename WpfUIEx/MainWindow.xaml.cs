using Serilog;
using System.Windows;

namespace WpfUIEx
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ILogger _logger;
        public MainWindow()
        {
            // Create logger File. This logger will be used globally.
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .Enrich.WithThreadId()
                .WriteTo.File("logs/WpfUIEx.log",
                    rollingInterval: RollingInterval.Day,
                    outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {SourceContext} [{ThreadId}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();

            InitializeComponent();

            _logger = Log.ForContext<MainWindow>();

            _logger.Debug("Entering the application");
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

        private void EventHandlersMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new EventHandlerEx1();
        }
    }
}