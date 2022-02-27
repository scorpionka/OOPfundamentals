using System.Collections.Generic;

namespace LibraryDomain.Models
{
    public class LocalizedBook : Document
    {
        public string ISBN { get; set; }
        public List<string> Authors { get; set; }
        public int NumberOfPages { get; set; }
        public string OriginalPublisher { get; set; }
        public Country CountryOfLocalization { get; set; }
        public string LocalPublisher { get; set; }
    }
}
