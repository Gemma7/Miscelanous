using System.Windows;

namespace WpfTutorialSamples.CommonInterfaceControls
{
    /// <summary>
    /// Interaction logic for StatusBarSample.xaml
    /// </summary>
    public partial class StatusBarSample : Window
    {
        public StatusBarSample()
        {
            InitializeComponent();
        }

        private void txtEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
            int column = txtEditor.CaretIndex - txtEditor.GetCharacterIndexFromLineIndex(row);

            lblCursorPosition.Text = "Line " + (row + 1) + ", Char " + (column + 1);
        }
    }
}
