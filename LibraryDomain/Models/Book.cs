using System;
using System.Collections.Generic;

namespace LibraryDomain.Models
{
    public class Book : Document
    {
        public string ISBN { get; set; }
        public List<string> Authors { get; set; }
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; }
    }
}
