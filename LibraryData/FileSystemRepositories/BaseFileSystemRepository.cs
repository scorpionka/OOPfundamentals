using LibraryData.Cache;
using LibraryDomain.Models;
using LibraryDomain.Repositories.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.IO;

namespace LibraryData.FileSystemRepositories
{
    public class BaseFileSystemRepository : IBaseRepository
    {
        private readonly DocumentMemoryCache<Book> bookMemoryCache = new DocumentMemoryCache<Book>();
        private readonly DocumentMemoryCache<LocalizedBook> localizedBookMemoryCache = new DocumentMemoryCache<LocalizedBook>();
        private readonly DocumentMemoryCache<Patent> patentMemoryCache = new DocumentMemoryCache<Patent>();

        public IEnumerable<Document> GetDocuments(int id)
        {
            foreach (var fileName in FindDocumentFileNames(id))
            {
                if (fileName.Contains("Book") && !fileName.Contains("LocalizedBook"))
                {
                    var book = bookMemoryCache.GetOrCreate(
                        $"Book{id}",
                        () => Serializers.JsonSerializerTool<Book>.DeserializeDocument(fileName),
                        new MemoryCacheEntryOptions()
                        .SetSize(1)
                        .SetAbsoluteExpiration(TimeSpan.FromMinutes(5)));
                    yield return book;
                }
                else if (fileName.Contains("LocalizedBook"))
                {
                    var localizedBook = localizedBookMemoryCache.GetOrCreate(
                        $"LocalizedBook{id}",
                        () => Serializers.JsonSerializerTool<LocalizedBook>.DeserializeDocument(fileName),
                        new MemoryCacheEntryOptions()
                        .SetSize(1)
                        .SetAbsoluteExpiration(TimeSpan.FromMinutes(10)));
                    yield return localizedBook;
                }
                else if (fileName.Contains("Patent"))
                {
                    var patent = patentMemoryCache.GetOrCreate(
                        $"Patent{id}",
                        () => Serializers.JsonSerializerTool<Patent>.DeserializeDocument(fileName),
                        new MemoryCacheEntryOptions()
                        .SetSize(1));
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
