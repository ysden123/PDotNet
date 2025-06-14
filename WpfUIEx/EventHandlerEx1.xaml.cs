using System.Windows;
using System.Windows.Controls;

namespace WpfUIEx
{
    /// <summary>
    /// Interaction logic for EventHandlerEx1.xaml
    /// </summary>
    public partial class EventHandlerEx1 : UserControl
    {
        public EventHandlerEx1()
        {
            InitializeComponent();
            ResultText.Text = $"Initialization {Environment.CurrentManagedThreadId}";
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ResultText.Text = $"Button 1 {Environment.CurrentManagedThreadId}";
        }

        private async void Button2_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() => {
                var threadId = Environment.CurrentManagedThreadId;
                this.Dispatcher.Invoke(() =>
                {
                    ResultText.Text = $"Button 2 {threadId}";
                });
            });
        }
    }
}
