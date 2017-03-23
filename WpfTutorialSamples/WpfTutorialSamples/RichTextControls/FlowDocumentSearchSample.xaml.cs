using System.Windows;

namespace WpfTutorialSamples.RichTextControls
{
    /// <summary>
    /// Interaction logic for FlowDocumentSearchSample.xaml
    /// </summary>
    public partial class FlowDocumentSearchSample : Window
    {
        public FlowDocumentSearchSample()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            fdViewer.Find();
        }
    }
}
