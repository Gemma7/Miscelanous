using System.Windows;
using System.Windows.Input;

namespace WpfTutorialSamples.Commands
{
    /// <summary>
    /// Interaction logic for CommandCanExecuteSample.xaml
    /// </summary>
    public partial class CommandCanExecuteSample : Window
    {
        public CommandCanExecuteSample()
        {
            InitializeComponent();
        }

        private void CutCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (txtEditor != null) && (txtEditor.SelectionLength > 0);
        }

        private void CutComman_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtEditor.Cut();
        }

        private void PasteCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Clipboard.ContainsText();
        }

        private void PasteCommand_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            txtEditor.Paste();
        }
    }
}
