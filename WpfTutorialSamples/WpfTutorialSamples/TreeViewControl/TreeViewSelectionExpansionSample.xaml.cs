using System.Collections.Generic;
using System.Windows;

namespace WpfTutorialSamples.TreeViewControl
{
    /// <summary>
    /// Interaction logic for TreeViewSelectionExpansionSample.xaml
    /// </summary>
    public partial class TreeViewSelectionExpansionSample : Window
    {
        public TreeViewSelectionExpansionSample()
        {
            InitializeComponent();

            CreateTreeData();
        }

        private void CreateTreeData()
        {
            List<Person> persons = new List<Person>();

            Person person1 = new Person() { Name = "John Doe", Age = 42 };

            Person person2 = new Person() { Name = "Jane Doe", Age = 39 };

            Person child1 = new Person() { Name = "Sammy Doe", Age = 13 };
            person1.Children.Add(child1);
            person2.Children.Add(child1);

            person2.Children.Add(new Person() { Name = "Jenny Moe", Age = 17 });

            Person person3 = new Person() { Name = "Becky Toe", Age = 25 };

            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);

            person1.IsExpanded = true;
            person2.IsSelected = true;

            trvPersons.ItemsSource = persons;
        }

        private void btnSelectNext_Click(object sender, RoutedEventArgs e)
        {
            if(trvPersons.SelectedItem != null)
            {
                var list = (trvPersons.ItemsSource as List<Person>);
                int curIndex = list.IndexOf(trvPersons.SelectedItem as Person);

                if(curIndex >= 0)
                    curIndex++;

                if (curIndex >= list.Count)
                    curIndex = 0;

                if (curIndex >= 0)
                    list[curIndex].IsSelected = true;
            }
        }

        private void btnToggleExpansion_Click(object sender, RoutedEventArgs e)
        {
            if (trvPersons.SelectedItem != null)
                (trvPersons.SelectedItem as Person).IsExpanded = !(trvPersons.SelectedItem as Person).IsExpanded;
        }
    }
}
