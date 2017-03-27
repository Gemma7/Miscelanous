using System.Collections.ObjectModel;

namespace WpfTutorialSamples.TreeViewControl
{
    public class MyMenuItem
    {
        public MyMenuItem()
        {
            Items = new ObservableCollection<MyMenuItem>();
        }

        public string Title { get; set; }

        public ObservableCollection<MyMenuItem> Items { get; set; }
    }
}