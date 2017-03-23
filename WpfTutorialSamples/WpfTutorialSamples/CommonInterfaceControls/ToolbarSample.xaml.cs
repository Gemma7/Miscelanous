using System.Windows;
using System.Windows.Input;

namespace WpfTutorialSamples.CommonInterfaceControls
{
    /// <summary>
    /// Interaction logic for ToolbarSample.xaml
    /// </summary>
    public partial class ToolbarSample : Window
    {
        public ToolbarSample()
        {
            InitializeComponent();
        }

        private void CommonCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }        
    }
}
