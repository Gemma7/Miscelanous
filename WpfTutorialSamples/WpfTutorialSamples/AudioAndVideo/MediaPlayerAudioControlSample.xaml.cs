using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace WpfTutorialSamples.AudioAndVideo
{
    /// <summary>
    /// Interaction logic for MediaPlayerAudioControlSample.xaml
    /// </summary>
    public partial class MediaPlayerAudioControlSample : Window
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();

        public MediaPlayerAudioControlSample()
        {
            InitializeComponent();

            OpenFileDialog();

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
            if(mediaPlayer.Source == null)
                lbStatus.Content = "No file selected";

            lbStatus.Content = string.Format("{0} / {1}", mediaPlayer.Position.ToString(@"mm\:ss"),
                                                          mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
        }

        private void OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";

            if ((bool)openFileDialog.ShowDialog())
            {
                mediaPlayer.Open(new Uri(openFileDialog.FileName));
            }
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }
    }
}
