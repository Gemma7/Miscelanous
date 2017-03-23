using System.Windows;

namespace WpfTutorialSamples.Introduction
{
    /// <summary>
    /// Interaction logic for ResourcesFromCodeBehindSample.xaml
    /// </summary>
    public partial class ResourcesFromCodeBehindSample : Window
    {
        public ResourcesFromCodeBehindSample()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Items.Add(pnlMain.FindResource("strPanel")).ToString();
            lblResult.Items.Add(FindResource("strWindow")).ToString();
            lblResult.Items.Add(Application.Current.FindResource("strApp")).ToString();
        }
    }
}
