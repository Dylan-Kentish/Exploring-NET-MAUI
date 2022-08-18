namespace MauiApp1.Models
{
    public class Category
    {
        public Category()
        {
        }

        public Category(string name, string uri)
        {
            Name = name;
            Uri = uri;
        }

        public string Name { get; set; }
        public string Uri { get; set; }
    }
}
