using System.Speech.Recognition;
using System.Windows;

namespace WpfTutorialSamples.AudioAndVideo
{
    /// <summary>
    /// Interaction logic for SpeechRecognitionTextSample.xaml
    /// </summary>
    public partial class SpeechRecognitionTextSample : Window
    {
        public SpeechRecognitionTextSample()
        {
            InitializeComponent();
            SpeechRecognizer speechRecognizer = new SpeechRecognizer(); 
        }
    }
}
