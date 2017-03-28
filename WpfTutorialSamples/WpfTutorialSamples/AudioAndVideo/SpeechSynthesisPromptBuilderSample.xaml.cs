using System;
using System.Speech.Synthesis;
using System.Windows;

namespace WpfTutorialSamples.AudioAndVideo
{
    /// <summary>
    /// Interaction logic for SpeechSynthesisPromptBuilderSample.xaml
    /// </summary>
    public partial class SpeechSynthesisPromptBuilderSample : Window
    {
        public SpeechSynthesisPromptBuilderSample()
        {
            InitializeComponent();
        }

        private void tbnSayIt_Click(object sender, RoutedEventArgs e)
        {
            PromptBuilder promptBuilder = InitializePromptBuilder();

            InitializeSpeechSynthesizer(promptBuilder);
        }

        private PromptBuilder InitializePromptBuilder()
        {
            PromptBuilder promptBuilder = new PromptBuilder();
            promptBuilder.AppendText("Hello world");

            PromptStyle promptStyle = new PromptStyle();
            promptStyle.Volume = PromptVolume.Soft;
            promptStyle.Rate = PromptRate.Slow;

            promptBuilder.StartStyle(promptStyle);
            promptBuilder.AppendText("and hello to the universe too.");
            promptBuilder.EndStyle();

            promptBuilder.AppendText("On this day, ");
            promptBuilder.AppendTextWithHint(DateTime.Now.ToShortDateString(), SayAs.Date);

            promptBuilder.AppendText(" we're gathered here to learn");
            promptBuilder.AppendText("all", PromptEmphasis.Strong);
            promptBuilder.AppendText("about");
            promptBuilder.AppendTextWithHint("WPF", SayAs.SpellOut);

            return promptBuilder;
        }

        private void InitializeSpeechSynthesizer(PromptBuilder promptBuilder)
        {
            SpeechSynthesizer speechSynthetizer = new SpeechSynthesizer();
            speechSynthetizer.Speak(promptBuilder);
        }
    }
}
