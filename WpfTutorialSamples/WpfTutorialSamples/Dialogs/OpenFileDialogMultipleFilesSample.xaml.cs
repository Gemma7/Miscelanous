using Microsoft.Win32;
using System;
using System.Windows;

namespace WpfTutorialSamples.Dialogs
{
    /// <summary>
    /// Interaction logic for OpenFileDialogMultipleFilesSample.xaml
    /// </summary>
    public partial class OpenFileDialogMultipleFilesSample : Window
    {
        public OpenFileDialogMultipleFilesSample()
        {
            InitializeComponent();
        }

        private void btnOpenFiles_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if ((bool)openFileDialog.ShowDialog())
                foreach (string fileName in openFileDialog.FileNames)
                    lblFiles.Items.Add(System.IO.Path.GetFileName(fileName));
        }
    }
}
