using System.Collections.ObjectModel;

namespace WpfTutorialSamples.TreeViewControl
{
    public class Person : TreeViewItemBase
    {
        public Person()
        {
            Children = new ObservableCollection<Person>();
        }
        public string Name { get; set; }

        public int Age { get; set; }

        public ObservableCollection<Person> Children { get; set; }
    }
}