using System;
using System.Collections.Generic;

namespace LibraryDomain.Models
{
    public class Document
    {
        public int Id { get; set; }
        public DocumentType DocumentType { get; set; }
        public string Title { get; set; }
        public DateTime DatePublished { get; set; }
        public string ISBN { get; set; }
        public List<string> Authors { get; set; }
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; }
        public string OriginalPublisher { get; set; }
        public Country CountryOfLocalization { get; set; }
        public string LocalPublisher { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
