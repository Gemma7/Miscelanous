using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace WpfTutorialSamples.ListViewControls
{
    /// <summary>
    /// Interaction logic for ListViewSortingSample.xaml
    /// </summary>
    public partial class ListViewSortingSample : Window
    {
        public ListViewSortingSample()
        {
            InitializeComponent();

            FillListView();

            SortingData();
        }

        private void SortingData()
        {
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            view.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));
            view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
        }

        private void FillListView()
        {
            List<User> items = new List<User>();

            items.Add(new User() { Name = "John Doe", Age = 42 });
            items.Add(new User() { Name = "Jane Doe", Age = 39 });
            items.Add(new User() { Name = "Sammy Doe", Age = 13 });
            items.Add(new User() { Name = "Donna Doe", Age = 13 });

            lvUsers.ItemsSource = items;
        }
    }
}
   
