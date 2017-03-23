using System.Windows;

namespace WpfTutorialSamples.Dialogs
{
    /// <summary>
    /// Interaction logic for MessageBoxSample.xaml
    /// </summary>
    public partial class MessageBoxSample : Window
    {
        public MessageBoxSample()
        {
            InitializeComponent();
        }

        private void btnSimpleMessageBox_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, world");
        }

        private void btnMessageBoxWithTitle_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, world", "My App");
        }

        private void btnMessageBoxWithButtons_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This MessageBox has extra options \n\nHello, world?", "MyApp", MessageBoxButton.YesNoCancel);
        }

        private void btnMessageBoxWithResponse_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Would you like to greet the world with a\n\nHello, world?", "MyApp", MessageBoxButton.YesNoCancel);
            
            switch(result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Hello to you too!", "My App");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Oh well, too bad!", "My App");
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("Neverming then...", "My App");
                    break;
            }
        }

        private void btnMessageBoxWithIcon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This MessageBox has extra options \n\nHello, world?", "MyApp", MessageBoxButton.OK,
                            MessageBoxImage.Information);
        }

        private void btnMessageBoxWithDefaultChoice_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This MessageBox has extra options \n\nHello, world?", "MyApp", MessageBoxButton.YesNo,
                            MessageBoxImage.Question, MessageBoxResult.No);
        }
    }
}
