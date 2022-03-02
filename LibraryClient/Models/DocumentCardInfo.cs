using LibraryDomain.Models;

namespace LibraryClient.Models
{
    public class DocumentCardInfo
    {
        public int Id { get; set; }
        public DocumentType DocumentType { get; set; }
        public string Title { get; set; }
        public string DatePublished { get; set; }
    }
}
