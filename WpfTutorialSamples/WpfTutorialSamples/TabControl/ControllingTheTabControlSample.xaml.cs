using System.Windows;
using System.Windows.Controls;

namespace WpfTutorialSamples.TabControl
{
    /// <summary>
    /// Interaction logic for ControllingTheTabControlSample.xaml
    /// </summary>
    public partial class ControllingTheTabControlSample : Window
    {
        public ControllingTheTabControlSample()
        {
            InitializeComponent();
        }

        private void btnPreviousTab_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tcSample.SelectedIndex - 1;
            if (newIndex < 0)
                newIndex = tcSample.Items.Count - 1;

            tcSample.SelectedIndex = newIndex;
        }

        private void btnPNextTab_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tcSample.SelectedIndex + 1;
            if (newIndex >= tcSample.Items.Count)
                newIndex = 0;

            tcSample.SelectedIndex = newIndex;
        }

        private void btnSelectedTab_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Selected tab: " + (tcSample.SelectedItem as TabItem).Header);
        }
    }
}
