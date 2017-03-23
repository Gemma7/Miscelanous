using System;
using System.Windows;

namespace WpfTutorialSamples.Introduction
{
    /// <summary>
    /// Interaction logic for ExceptionHandlingSample.xaml
    /// </summary>
    public partial class ExceptionHandlingSample : Window
    {
        public ExceptionHandlingSample()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = null;
            try
            {
                s.Trim();
            }
            catch(Exception ex)
            {
                MessageBox.Show("A handled exception just ocurred: " + ex.Message,
                                "Exception Message", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            s.Trim();
        }
    }
}
