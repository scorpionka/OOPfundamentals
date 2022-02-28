using LibraryDomain.Models;
using System.Collections.Generic;

namespace LibraryDomain.DomainServices.Interfaces
{
    public interface IBaseDomainService
    {
        public List<Document> GetDocuments();
        public bool AddDocument(Document document);
    }
}
