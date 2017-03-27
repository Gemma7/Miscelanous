using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;

namespace WpfTutorialSamples.ListViewControls
{
    /// <summary>
    /// Interaction logic for ListViewGroupSample.xaml
    /// </summary>
    public partial class ListViewGroupSample : Window
    {
        public ListViewGroupSample()
        {
            InitializeComponent();
            FillListView();

            GroupingData();
        }

        private void GroupingData()
        {
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Sex");
            view.GroupDescriptions.Add(groupDescription);
        }

        private void FillListView()
        {
            List<User> items = new List<User>();

            items.Add(new User() { Name = "John Doe", Age = 42, Sex = SexType.Male });
            items.Add(new User() { Name = "Jane Doe", Age = 39, Sex = SexType.Female });
            items.Add(new User() { Name = "Sammy Doe", Age = 13, Sex = SexType.Male });

            lvUsers.ItemsSource = items;
        }
    }
}
