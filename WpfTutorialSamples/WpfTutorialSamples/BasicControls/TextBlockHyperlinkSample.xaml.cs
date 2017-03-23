using System.Windows;

namespace WpfTutorialSamples.BasicControls
{
    /// <summary>
    /// Interaction logic for TextBlockHyperlinkSample.xaml
    /// </summary>
    public partial class TextBlockHyperlinkSample : Window
    {
        public TextBlockHyperlinkSample()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }
    }
}
