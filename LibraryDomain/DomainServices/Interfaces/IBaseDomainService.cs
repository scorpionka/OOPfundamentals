using LibraryDomain.Models;
using System.Collections.Generic;

namespace LibraryDomain.DomainServices.Interfaces
{
    public interface IBaseDomainService
    {
        public IEnumerable<Document> GetDocuments();
    }
}
