using LibraryDomain.Models;
using System.Collections.Generic;

namespace LibraryDomain.Repositories.Interfaces
{
    public interface IBaseRepository
    {
        public IEnumerable<Document> GetDocuments(int id);
    }
}
