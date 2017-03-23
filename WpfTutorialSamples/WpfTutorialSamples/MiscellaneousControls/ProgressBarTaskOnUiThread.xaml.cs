using System;
using System.Threading;
using System.Windows;

namespace WpfTutorialSamples.MiscellaneousControls
{
    /// <summary>
    /// Interaction logic for ProgressBarTaskOnUiThread.xaml
    /// </summary>
    public partial class ProgressBarTaskOnUiThread : Window
    {
        public ProgressBarTaskOnUiThread()
        {
            InitializeComponent();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                pbStatus.Value++;
                Thread.Sleep(100);
            }
        }
    }
}
