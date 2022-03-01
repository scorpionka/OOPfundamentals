using System.Collections.Generic;

namespace LibraryClient.Models
{
    public class PatentCardInfo : DocumentCardInfo
    {
        public List<string> Authors { get; set; }
        public string ExpirationDate { get; set; }
        public int UniqueId { get; set; }
    }
}
