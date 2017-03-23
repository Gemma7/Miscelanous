using System.Collections.ObjectModel;
using System.Windows;

namespace WpfTutorialSamples.DataBinding
{
    /// <summary>
    /// Interaction logic for ChangeNotificationSample.xaml
    /// </summary>
    public partial class ChangeNotificationSample : Window
    {
        private ObservableCollection<User> users = new ObservableCollection<User>();
        public ChangeNotificationSample()
        {
            InitializeComponent();

            users.Add(new User() { Name = "John Doe" });
            users.Add(new User() { Name = "Jane Doe" });

            lbUsers.ItemsSource = users;
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User() { Name = "New user" });
        }

        private void btnChangeUser_Click(object sender, RoutedEventArgs e)
        {
            if(lbUsers.SelectedItem != null)
                (lbUsers.SelectedItem as User).Name = "Random name";
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
                users.Remove(lbUsers.SelectedItem as User);
        }
    }
}
