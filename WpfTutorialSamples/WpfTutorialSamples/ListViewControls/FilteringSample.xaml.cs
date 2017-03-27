using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfTutorialSamples.ListViewControls
{
    /// <summary>
    /// Interaction logic for FilteringSample.xaml
    /// </summary>
    public partial class FilteringSample : Window
    {
        public FilteringSample()
        {
            InitializeComponent();

            FillListView();

            FilterData();
        }

        private void FilterData()
        {
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            view.Filter = UserFilter;
        }

        private bool UserFilter(object obj)
        {
            if (string.IsNullOrEmpty(txtFilter.Text))
                return true;

            return (obj as User).Name.IndexOf(txtFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0;
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

        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lvUsers.ItemsSource).Refresh();
        }
    }
}
