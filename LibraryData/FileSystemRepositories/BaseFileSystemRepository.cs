using LibraryDomain.Models;
using LibraryDomain.Repositories.Interfaces;
using System.Collections.Generic;

namespace LibraryData.FileSystemRepositories
{
    public class BaseFileSystemRepository : IBaseRepository
    {
        private List<Document> documentList = new List<Document>();

        public IEnumerable<Document> GetDocuments()
        {
            return Serializers.JsonSerializerTool<Document>.DeserializeLibrary();
        }
    }
}
