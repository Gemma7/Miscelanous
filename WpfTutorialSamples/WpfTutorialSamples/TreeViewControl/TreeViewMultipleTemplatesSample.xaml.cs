using System.Collections.Generic;
using System.Windows;

namespace WpfTutorialSamples.TreeViewControl
{
    /// <summary>
    /// Interaction logic for TreeViewMultipleTemplatesSample.xaml
    /// </summary>
    public partial class TreeViewMultipleTemplatesSample : Window
    {
        public TreeViewMultipleTemplatesSample()
        {
            InitializeComponent();

            CreateData();
        }

        private void CreateData()
        {
            List<Family> families = new List<Family>();

            Family family1 = new Family { Name = "The Doe's" };
            family1.Members.Add(new FamilyMember { Name = "John Doe", Age = 42 });
            family1.Members.Add(new FamilyMember { Name = "Jane Doe", Age = 39 });
            family1.Members.Add(new FamilyMember { Name = "Sammy Doe", Age = 13 });
            families.Add(family1);

            Family family2 = new Family() { Name = "The Moe's" };
            family2.Members.Add(new FamilyMember { Name = "Mark Moe", Age = 31 });
            family2.Members.Add(new FamilyMember { Name = "Norma Moe", Age = 28 });
            families.Add(family2);

            trvFamilies.ItemsSource = families;
        }
    }
}
