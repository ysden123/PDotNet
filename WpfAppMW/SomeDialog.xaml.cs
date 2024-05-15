using System.Windows;

namespace WpfAppMW
{
    /// <summary>
    /// Interaction logic for SomeDialog.xaml
    /// </summary>
    public partial class SomeDialog : Window
    {
        private SomeDialogData _data;
        public SomeDialog(SomeDialogData someDialogData)
        {
            InitializeComponent();
            _data = someDialogData;
            textBox.Text = _data.T1;
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            _data.T1 = textBox.Text;
            DialogResult = true;
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
