using System.Speech.Recognition;
using System.Windows;
using System.Windows.Media;

namespace WpfTutorialSamples.AudioAndVideo
{
    /// <summary>
    /// Interaction logic for SpeechRecognitionCommandsSample.xaml
    /// </summary>
    public partial class SpeechRecognitionCommandsSample : Window
    {
        private SpeechRecognitionEngine speechRecognizer = new SpeechRecognitionEngine();
         
        public SpeechRecognitionCommandsSample()
        {
            InitializeComponent();

            InitializeSpeech();
        }

        private void InitializeSpeech()
        {
            speechRecognizer.SpeechRecognized += SpeechRecognizer_SpeechRecognized;

            GrammarBuilder grammarBuilder = CreateGrammarBuilder();

            speechRecognizer.LoadGrammar(new Grammar(grammarBuilder));
            speechRecognizer.SetInputToDefaultAudioDevice();
        }

        private GrammarBuilder CreateGrammarBuilder()
        {
            GrammarBuilder grammarBuilder = new GrammarBuilder();
            Choices commandChoices = new Choices("weight", "color", "size");
            grammarBuilder.Append(commandChoices);

            Choices valueChoices = InitializeChoices();

            grammarBuilder.Append(valueChoices);

            return grammarBuilder;
        }

        private Choices InitializeChoices()
        {
            Choices valueChoices = new Choices();
            valueChoices.Add("normal", "bold");
            valueChoices.Add("red", "green", "blue");
            valueChoices.Add("small", "medium", "large");

            return valueChoices;
        }

        private void SpeechRecognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            lblDemo.Content = e.Result.Text;

            if(e.Result.Words.Count == 2)
            {
                string command = e.Result.Words[0].Text.ToLower();
                string value = e.Result.Words[1].Text.ToLower();

                switch(command)
                {
                    case "weight":
                        FontWeightConverter weightConverter = new FontWeightConverter();
                        lblDemo.FontWeight = (FontWeight)weightConverter.ConvertFromString(value);
                        break;
                    case "color":
                        lblDemo.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(value));
                        break;
                    case "size":
                        switch (value)
                        {
                            case "small":
                                lblDemo.FontSize = 12;
                                break;
                            case "medium":
                                lblDemo.FontSize = 24;
                                break;
                            case "large":
                                lblDemo.FontSize = 48;
                                break;
                        }
                        break;
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            speechRecognizer.Dispose();
        }

        private void btnToggleListening_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)btnToggleListening.IsChecked)
                speechRecognizer.RecognizeAsync(RecognizeMode.Multiple);

            speechRecognizer.RecognizeAsync();
        }
    }
}
