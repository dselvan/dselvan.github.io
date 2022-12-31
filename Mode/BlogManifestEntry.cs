namespace dselvan.github.io.Models
{
    public class BlogManifestEntry
    {
        public string Title { get; set; } = "";
        public string Author { get; set; } = "Deepak Selvan";
        public DateTime Date { get; set; } = DateTime.Now;
        public string Path { get; set; } = "";
        public List<string> Tags { get; set; } = new();
    }
}