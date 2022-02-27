using System;
using System.Collections.Generic;

namespace LibraryDomain.Models
{
    public class Patent : Document
    {
        public List<string> Authors { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
