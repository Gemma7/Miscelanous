using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace WpfTutorialSamples.Miscellaneous
{
    /// <summary>
    /// Interaction logic for BackgroundWorkerCancellationSample.xaml
    /// </summary>
    public partial class BackgroundWorkerCancellationSample : Window
    {
        private BackgroundWorker worker = null;

        public BackgroundWorkerCancellationSample()
        {
            InitializeComponent();

            InitializeWorker();
        }

        private void InitializeWorker()
        {
            worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;  
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblStatus.Foreground = Brushes.Red;
                lblStatus.Text = "Cancelled by user...";
            }

            lblStatus.Foreground = Brushes.Green;
            lblStatus.Text = "Done...Calc result: " + e.Result;            
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = "Working....(" + e.ProgressPercentage + "%)";
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 0; i <= 100; i++)
            {
                if(worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                worker.ReportProgress(1);
                System.Threading.Thread.Sleep(1);
            }

            e.Result = 42;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            worker.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            worker.CancelAsync();
        }
    }
}
