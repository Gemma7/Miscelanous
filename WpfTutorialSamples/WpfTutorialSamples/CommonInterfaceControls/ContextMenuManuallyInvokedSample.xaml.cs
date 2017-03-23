using System.Windows;
using System.Windows.Controls;

namespace WpfTutorialSamples.CommonInterfaceControls
{
    /// <summary>
    /// Interaction logic for ContextMenuManuallyInvokedSample.xaml
    /// </summary>
    public partial class ContextMenuManuallyInvokedSample : Window
    {
        public ContextMenuManuallyInvokedSample()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = FindResource("cmButton") as ContextMenu;
            cm.PlacementTarget = sender as Button;
            cm.IsOpen = true;
        }
    }
}
