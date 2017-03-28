using System;
using System.Windows;
using System.Windows.Threading;

namespace WpfTutorialSamples.Miscellaneous
{
    /// <summary>
    /// Interaction logic for DispatcherTimerSample.xaml
    /// </summary>
    public partial class DispatcherTimerSample : Window
    {
        public DispatcherTimerSample()
        {
            InitializeComponent();

            InitializeTimer();
        }

        private void InitializeTimer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //lblTime.Content = DateTime.Now.ToLongTimeString();
            lblTime.Content = DateTime.Now.ToString("HH:mm:ss.fff");
        }
    }
}
