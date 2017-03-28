using System.Speech.Synthesis;
using System.Windows;

namespace WpfTutorialSamples.AudioAndVideo
{
    /// <summary>
    /// Interaction logic for SpeechSynthesisSample.xaml
    /// </summary>
    public partial class SpeechSynthesisSample : Window
    {
        public SpeechSynthesisSample()
        {
            InitializeComponent();
        }

        private void tbnSayIt_Click(object sender, RoutedEventArgs e)
        {
            SpeechSynthesizer speechSyntetizer = new SpeechSynthesizer();
            speechSyntetizer.Speak("Hello, world!");
        }
    }
}
