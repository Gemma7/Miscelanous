using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

namespace WpfTutorialSamples.ListViewControls
{
    /// <summary>
    /// Interaction logic for ListViewGridViewCellTemplateSample.xaml
    /// </summary>
    public partial class ListViewGridViewCellTemplateSample : Window
    {
        public ListViewGridViewCellTemplateSample()
        {
            InitializeComponent();

            FillListView();
        }

        private void FillListView()
        {
            List<User> items = new List<User>();

            items.Add(new User() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
            items.Add(new User() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" });
            items.Add(new User() { Name = "Sammy Doe", Age = 13, Mail = "sammy.doe@gmail.com" });

            lvUsers.ItemsSource = items;
        }
    }
}
