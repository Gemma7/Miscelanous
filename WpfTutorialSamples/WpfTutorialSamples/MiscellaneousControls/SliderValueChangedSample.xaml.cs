using System.Windows;
using System.Windows.Media;

namespace WpfTutorialSamples.MiscellaneousControls
{
    /// <summary>
    /// Interaction logic for SliderValueChangedSample.xaml
    /// </summary>
    public partial class SliderValueChangedSample : Window
    {
        public SliderValueChangedSample()
        {
            InitializeComponent();
        }

        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color color = Color.FromRgb((byte)slColorR.Value, (byte)slColorG.Value, (byte)slColorB.Value);
            Background = new SolidColorBrush(color);
        }

    }
}
