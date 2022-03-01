using System.Collections.Generic;

namespace LibraryDomain.Models
{
    public class Patent : Document
    {
        public List<string> Authors { get; set; }
        public string ExpirationDate { get; set; }
        public int UniqueId { get; set; }
    }
}
