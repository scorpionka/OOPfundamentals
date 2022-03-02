using System.Collections.Generic;

namespace LibraryClient.Models
{
    public class BookCardInfo : DocumentCardInfo
    {
        public string ISBN { get; set; }
        public List<string> Authors { get; set; }
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; }
    }
}
