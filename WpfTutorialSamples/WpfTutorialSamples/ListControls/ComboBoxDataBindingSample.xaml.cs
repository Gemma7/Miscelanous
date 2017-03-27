using System.Windows;
using System.Windows.Media;

namespace WpfTutorialSamples.ListControls
{
    /// <summary>
    /// Interaction logic for ComboBoxDataBindingSample.xaml
    /// </summary>
    public partial class ComboBoxDataBindingSample : Window
    {
        public ComboBoxDataBindingSample()
        {
            InitializeComponent();

            cmbColors.ItemsSource = typeof(Colors).GetProperties();
        }
    }
}
