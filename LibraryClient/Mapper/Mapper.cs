using LibraryClient.Models;
using LibraryDomain.Models;
using System.Collections.Generic;

namespace LibraryClient.Mapper
{
    public static class Mapper
    {
        public static List<DocumentCardInfo> MapToDocumentCardInfoList(List<Document> documents)
        {
            var documentsCardInfos = new List<DocumentCardInfo>();

            foreach (var document in documents)
            {
                var cardInfo = new DocumentCardInfo()
                {
                    Id = document.Id,
                    Title = document.Title != null ? document.Title : "N/A",
                    DocumentType = document.DocumentType,
                    DatePublished = document.DatePublished,
                    ISBN = document.ISBN != null ? document.ISBN : "N/A",
                    Authors = document.Authors != null ? document.Authors : new List<string>() { "N/A"},
                    NumberOfPages = document.NumberOfPages,
                    Publisher = document.Publisher != null ? document.Publisher : "N/A",
                    OriginalPublisher = document.OriginalPublisher != null ? document.OriginalPublisher : "N/A",
                    CountryOfLocalization = document.CountryOfLocalization,
                    LocalPublisher = document.LocalPublisher != null ? document.LocalPublisher : "N/A",
                    ExpirationDate = document.ExpirationDate,
                };
                documentsCardInfos.Add(cardInfo);
            }

            return documentsCardInfos;
        }

        public static Document MapToDocument(DocumentCardInfo documentCardInfo)
        {
            return new Document()
            {
                Id = documentCardInfo.Id,
                Title = documentCardInfo.Title,
                DocumentType = documentCardInfo.DocumentType,
                DatePublished = documentCardInfo.DatePublished,
                ISBN = documentCardInfo.ISBN,
                Authors = documentCardInfo.Authors,
                NumberOfPages = documentCardInfo.NumberOfPages,
                Publisher = documentCardInfo.Publisher,
                OriginalPublisher = documentCardInfo.OriginalPublisher,
                CountryOfLocalization = documentCardInfo.CountryOfLocalization,
                LocalPublisher = documentCardInfo.LocalPublisher,
                ExpirationDate = documentCardInfo.ExpirationDate,
            };
        }
    }
}
