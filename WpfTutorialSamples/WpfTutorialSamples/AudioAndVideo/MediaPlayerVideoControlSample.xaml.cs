using System;
using System.Windows;
using System.Windows.Threading;

namespace WpfTutorialSamples.AudioAndVideo
{
    /// <summary>
    /// Interaction logic for MediaPlayerVideoControlSample.xaml
    /// </summary>
    public partial class MediaPlayerVideoControlSample : Window
    {
        public MediaPlayerVideoControlSample()
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
            if (mePlayer.Source == null)
                lblStatus.Content = "No file selected...";
            
            if(mePlayer.NaturalDuration.HasTimeSpan)
                lblStatus.Content = string.Format("{0}  / {1}", mePlayer.Position.ToString(@"mm\:ss"),
                                                                mePlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));

            lblStatus.Content = string.Format("{0}", mePlayer.Position.ToString(@"mm\:ss"));
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mePlayer.Play();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mePlayer.Stop();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mePlayer.Pause();
        }
    }
}
