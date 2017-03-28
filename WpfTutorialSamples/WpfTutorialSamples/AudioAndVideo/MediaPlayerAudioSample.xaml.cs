using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media;

namespace WpfTutorialSamples.AudioAndVideo
{
    /// <summary>
    /// Interaction logic for MediaPlayerAudioSample.xaml
    /// </summary>
    public partial class MediaPlayerAudioSample : Window
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();
        public MediaPlayerAudioSample()
        {
            InitializeComponent();
        }

        private void btnOpenAudioFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";

            if((bool)openFileDialog.ShowDialog())
            {
                mediaPlayer.Open(new Uri(openFileDialog.FileName));
                mediaPlayer.Play();
            }
        }
    }
}
