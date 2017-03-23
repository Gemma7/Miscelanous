using System.Windows;

namespace WpfTutorialSamples.Dialogs
{
    /// <summary>
    /// Interaction logic for InputDialogAppSample.xaml
    /// </summary>
    public partial class InputDialogAppSample : Window
    {
        public InputDialogAppSample()
        {
            InitializeComponent();
        }

        private void btnEnterName_Click(object sender, RoutedEventArgs e)
        {
            InputDialogSample inputDialog = new InputDialogSample("Please enter your name: ", "John Doe");
            if ((bool)inputDialog.ShowDialog())
                lblName.Text = inputDialog.Answer;
        }
    }
}
