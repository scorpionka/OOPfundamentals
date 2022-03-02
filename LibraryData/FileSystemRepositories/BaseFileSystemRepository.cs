using LibraryDomain.Models;
using LibraryDomain.Repositories.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace LibraryData.FileSystemRepositories
{
    public class BaseFileSystemRepository : IBaseRepository
    {
        public IEnumerable<Document> GetDocuments(int id)
        {
            foreach (var fileName in FindDocumentFileNames(id))
            {
                if (fileName.Contains("Book") && !fileName.Contains("LocalizedBook"))
                {
                    yield return Serializers.JsonSerializerTool<Book>.DeserializeDocument(fileName);
                }
                else if (fileName.Contains("LocalizedBook"))
                {
                    yield return Serializers.JsonSerializerTool<LocalizedBook>.DeserializeDocument(fileName);
                }
                else if (fileName.Contains("Patent"))
                {
                    yield return Serializers.JsonSerializerTool<Patent>.DeserializeDocument(fileName);
                }
                else if (fileName.Contains("Magazine"))
                {
                    yield return Serializers.JsonSerializerTool<Magazine>.DeserializeDocument(fileName);
                }
            }
        }

        private static IEnumerable<string> FindDocumentFileNames(int id)
        {
            string path = @"C:\Library";
            if (!Directory.Exists(path))
            {
                yield break;
            }

            string[] fileNames = Directory.GetFiles(path);

            foreach (string fileName in fileNames)
            {
                if (fileName.Contains(id.ToString()))
                {
                    yield return fileName;
                }
            }
        }
    }
}
