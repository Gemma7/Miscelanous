using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace WpfTutorialSamples.TreeViewControl
{
    /// <summary>
    /// Interaction logic for LazyLoadingSample.xaml
    /// </summary>
    public partial class LazyLoadingSample : Window
    {
        public LazyLoadingSample()
        {
            InitializeComponent();

            CreateTreeData();
        }

        private void CreateTreeData()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo driveInfo in drives)
                trvStructure.Items.Add(CreateTreeItem(driveInfo));
        }

        private object CreateTreeItem(object driveInfo)
        {
            TreeViewItem item = new TreeViewItem
            {
                Header = driveInfo.ToString(),
                Tag = driveInfo
            };

            item.Items.Add("Loading....");
            return item;
        }

        private void trvStructure_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = e.Source as TreeViewItem;

            if(item.Items.Count == 1 && item.Items[0] is string)
            {
                item.Items.Clear();

                DirectoryInfo expandedDir = null;

                if (item.Tag is DriveInfo)
                    expandedDir = (item.Tag as DriveInfo).RootDirectory;

                try
                {
                    foreach (DirectoryInfo subDir in expandedDir.GetDirectories())
                        item.Items.Add(CreateTreeItem(subDir));
                }
                catch{ }
            }
        }
    }
}
