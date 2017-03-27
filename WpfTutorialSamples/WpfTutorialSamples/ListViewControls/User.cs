
namespace WpfTutorialSamples.ListViewControls
{
    public class User
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return Name + ", " + Age + " years old";
        }

        public string Mail { get; set; }

        public SexType Sex { get; set; }
    }

    public enum SexType {  Male, Female };
}
