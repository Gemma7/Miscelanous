using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace WpfTutorialSamples.BasicControls
{
    /// <summary>
    /// Interaction logic for TextBlockCodeBehindSample.xaml
    /// </summary>
    public partial class TextBlockCodeBehindSample : Window
    {
        public TextBlockCodeBehindSample()
        {
            InitializeComponent();
            TextBlock tb = new TextBlock();
            tb.TextWrapping = TextWrapping.Wrap;
            tb.Margin = new Thickness(10);
            tb.Inlines.Add("An example on ");
            tb.Inlines.Add(new Run("the TextBlock control ") { FontWeight = FontWeights.Bold});
            tb.Inlines.Add("using ");
            tb.Inlines.Add(new Run("inline ") { FontStyle = FontStyles.Italic });
            tb.Inlines.Add(new Run("text formatting ") { Foreground = Brushes.DarkOrchid });
            tb.Inlines.Add("from ");
            tb.Inlines.Add(new Run("Code-Behind ") { TextDecorations = TextDecorations.Underline });
            tb.Inlines.Add(".");
            Content = tb;
        }
    }
}
