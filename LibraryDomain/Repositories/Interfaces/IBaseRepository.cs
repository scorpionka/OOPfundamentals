using LibraryDomain.Models;
using System.Collections.Generic;

namespace LibraryDomain.Repositories.Interfaces
{
    public interface IBaseRepository
    {
        public void AddDocument(Document document);
        public List<Document> GetDocuments();
    }
}
