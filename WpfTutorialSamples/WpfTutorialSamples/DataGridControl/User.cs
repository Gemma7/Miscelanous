using System;

namespace WpfTutorialSamples.DataGridControl
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string Details
        {
            get
            {
                return string.Format("{0} was born on {1} and this is a long description of the person",
                                     Name, Birthday.ToLongDateString());
            }
        }
    }
}