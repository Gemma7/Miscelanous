using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfTutorialSamples.ListControls
{
    /// <summary>
    /// Interaction logic for ListBoxSelectionSample.xaml
    /// </summary>
    public partial class ListBoxSelectionSample : Window
    {
        public ListBoxSelectionSample()
        {
            InitializeComponent();

            CreateItemList();
        }

        private void CreateItemList()
        {
            List<TodoItem> items = new List<TodoItem>();
            items.Add(new TodoItem { Title = "Complete this WPF tutorial", Completion = 45 });
            items.Add(new TodoItem() { Title = "Learn C#", Completion = 80 });
            items.Add(new TodoItem() { Title = "Wash the car", Completion = 0 });

            lbTodoList.ItemsSource = items;
        }

        private void btnShowSelectedItem_Click(object sender, RoutedEventArgs e)
        {
            foreach (object item in lbTodoList.SelectedItems)
                MessageBox.Show((item as TodoItem).Title);
        }

        private void btnSelectLast_Click(object sender, RoutedEventArgs e)
        {
            lbTodoList.SelectedIndex = lbTodoList.Items.Count - 1;
        }

        private void btnSelectedNext_Click(object sender, RoutedEventArgs e)
        {
            int nextIndex = 0;

            if (lbTodoList.SelectedIndex >= 0 &&
                lbTodoList.SelectedIndex < lbTodoList.Items.Count - 1)
                nextIndex = lbTodoList.SelectedIndex + 1;

            lbTodoList.SelectedIndex = nextIndex;
        }

        private void btnSelectedCSharp_Click(object sender, RoutedEventArgs e)
        {
            foreach(object item in lbTodoList.Items)
            {
                if(item is TodoItem && 
                    (item as TodoItem).Title.Contains("C#"))
                {
                    lbTodoList.SelectedItem = item;
                    break;
                }
            }
        }

        private void btnSelectAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (object item in lbTodoList.Items)
                lbTodoList.SelectedItems.Add(item);
        }

        private void lbTodoList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbTodoList.SelectedItem != null)
                Title = (lbTodoList.SelectedItem as TodoItem).Title;
        }
    }
}
