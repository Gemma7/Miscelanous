using System;
using System.Collections.Generic;
using System.Windows;

namespace WpfTutorialSamples.DataGridControl
{
    /// <summary>
    /// Interaction logic for DataGridDetailsSample.xaml
    /// </summary>
    public partial class DataGridDetailsSample : Window
    {
        public DataGridDetailsSample()
        {
            InitializeComponent();

            FillDataGrid();
        }

        private void FillDataGrid()
        {
            List<User> users = new List<User>();

            users.Add(new User() { Id = 1, Name = "John Doe", Birthday = new DateTime(1971, 7, 23) });
            users.Add(new User() { Id = 2, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17) });
            users.Add(new User() { Id = 3, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2) });

            dgUsers.ItemsSource = users;
        }
    }
}
