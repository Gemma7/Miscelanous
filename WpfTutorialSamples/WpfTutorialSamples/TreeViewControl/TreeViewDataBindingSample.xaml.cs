using System.Windows;

namespace WpfTutorialSamples.TreeViewControl
{
    /// <summary>
    /// Interaction logic for TreeViewDataBindingSample.xaml
    /// </summary>
    public partial class TreeViewDataBindingSample : Window
    {
        public TreeViewDataBindingSample()
        {
            InitializeComponent();

            CreateMenuItem();
        }

        private void CreateMenuItem()
        {
            MyMenuItem root = new MyMenuItem() { Title = "Menu" };
            MyMenuItem childItem1 = new MyMenuItem() { Title = "Child item #1" };
            childItem1.Items.Add(new MyMenuItem() { Title = "Child item #1.1" });
            childItem1.Items.Add(new MyMenuItem() { Title = "Child item #1.2" });

            root.Items.Add(childItem1);
            root.Items.Add(new MyMenuItem() { Title = "Child item #2" });

            trvMenu.Items.Add(root);
        }
    }
}
