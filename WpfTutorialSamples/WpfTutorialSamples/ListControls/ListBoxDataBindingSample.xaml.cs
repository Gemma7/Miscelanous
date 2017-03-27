using System.Collections.Generic;
using System.Windows;

namespace WpfTutorialSamples.ListControls
{
    /// <summary>
    /// Interaction logic for ListBoxDataBindingSample.xaml
    /// </summary>
    public partial class ListBoxDataBindingSample : Window
    {
        public ListBoxDataBindingSample()
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
    }
}
