using LibraryDomain.Models;
using LibraryDomain.Repositories.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace LibraryData.FileSystemRepositories
{
    public class BaseFileSystemRepository : IBaseRepository
    {
        private List<Document> documentList = new List<Document>();

        public void AddDocument(Document document)
        {
            documentList.Add(document);

            string fileName = "library.json";
            string jsonString = JsonSerializer.Serialize(documentList);
            File.WriteAllText(fileName, jsonString);
        }

        public IEnumerable<Document> GetDocuments()
        {
            string fileName = "library.json";
            string jsonString = File.ReadAllText(fileName);
            documentList = JsonSerializer.Deserialize<List<Document>>(jsonString);

            return documentList;
        }
    }
}
