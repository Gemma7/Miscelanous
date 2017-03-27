using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
namespace WpfTutorialSamples.ListViewControls
{
    /// <summary>
    /// Interaction logic for ListViewDataBindingSample.xaml
    /// </summary>
    public partial class ListViewDataBindingSample : Window
    {
        public ListViewDataBindingSample()
        {
            InitializeComponent();

            FillListView();
        }

        private void FillListView()
        {
            List<User> items = new List<User>();

            items.Add(new User() { Name = "John Doe", Age = 42 });
            items.Add(new User() { Name = "Jane Doe", Age = 39 });
            items.Add(new User() { Name = "Sammy Doe", Age = 13 });

            lvDataBinding.ItemsSource = items;
        }
    }
}
