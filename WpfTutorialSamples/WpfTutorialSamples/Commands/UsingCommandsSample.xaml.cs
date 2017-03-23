using System.Windows;
using System.Windows.Input;

namespace WpfTutorialSamples.Commands
{
    /// <summary>
    /// Interaction logic for UsingCommandsSample.xaml
    /// </summary>
    public partial class UsingCommandsSample : Window
    {
        public UsingCommandsSample()
        {
            InitializeComponent();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("The New command was invoked");
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
