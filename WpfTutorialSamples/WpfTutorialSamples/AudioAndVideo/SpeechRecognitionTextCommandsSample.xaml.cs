using System.Speech.Recognition;
using System.Windows;

namespace WpfTutorialSamples.AudioAndVideo
{
    /// <summary>
    /// Interaction logic for SpeechRecognitionTextCommandsSample.xaml
    /// </summary>
    public partial class SpeechRecognitionTextCommandsSample : Window
    {
        public SpeechRecognitionTextCommandsSample()
        {
            InitializeComponent();
            SpeechRecognizer speechRecognizer = new SpeechRecognizer();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            txtSpeech.Text = string.Empty;
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Command invoke: Open");
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Command invoke: Save");
        }
    }
}
