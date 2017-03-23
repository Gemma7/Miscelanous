using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace WpfTutorialSamples.Dialogs
{
    /// <summary>
    /// Interaction logic for OpenFileDialogSample.xaml
    /// </summary>
    public partial class OpenFileDialogSample : Window
    {
        public OpenFileDialogSample()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if ((bool)openFileDialog.ShowDialog())
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
        }
    }
}
