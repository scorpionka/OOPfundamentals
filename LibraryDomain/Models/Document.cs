namespace LibraryDomain.Models
{
    public class Document
    {
        public int Id { get; set; }
        public DocumentType DocumentType { get; set; }
        public string Title { get; set; }
        public string DatePublished { get; set; }
    }
}
