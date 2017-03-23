using System.Windows;
using System.Windows.Input;

namespace WpfTutorialSamples.CommonInterfaceControls
{
    /// <summary>
    /// Interaction logic for MenuWithCommandsSample.xaml
    /// </summary>
    public partial class MenuWithCommandsSample : Window
    {
        public MenuWithCommandsSample()
        {
            InitializeComponent();
        }

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtEditor.Text = string.Empty;
        }
    }
}
