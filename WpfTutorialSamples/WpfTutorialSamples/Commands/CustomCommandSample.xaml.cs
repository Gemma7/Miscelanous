using System.Windows;
using System.Windows.Input;

namespace WpfTutorialSamples.Commands
{
    /// <summary>
    /// Interaction logic for CustomCommandSample.xaml
    /// </summary>
    public partial class CustomCommandSample : Window
    {
        public CustomCommandSample()
        {
            InitializeComponent();
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
