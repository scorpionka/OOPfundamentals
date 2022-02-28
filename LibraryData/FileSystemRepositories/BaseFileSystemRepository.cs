using LibraryDomain.Models;
using LibraryDomain.Repositories.Interfaces;
using System.Collections.Generic;

namespace LibraryData.FileSystemRepositories
{
    public class BaseFileSystemRepository : IBaseRepository
    {
        private List<Document> list = new List<Document>();

        public void AddDocument(Document document)
        {
            list.Add(document);
        }

        public List<Document> GetDocuments()
        {
            return list;
        }
    }
}
