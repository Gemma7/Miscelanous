using System.Windows;
using System.Windows.Threading;

namespace WpfTutorialSamples
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //Create the startup window
            MainWindow window = new MainWindow();

            // Do stuff here, e.g. to the window
            //window.Title = "Something else";
            if (e.Args.Length == 1)
                MessageBox.Show("Now opening file: \n\n" + e.Args[0]);

            //Show the window
            window.Show();
        }

        private void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled exception just ocurred: " + e.Exception.Message, "Exception Message",
                            MessageBoxButton.OK, MessageBoxImage.Error);

            e.Handled = true;
        }
    }
}
