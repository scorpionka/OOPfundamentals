using LibraryClient.Models;
using LibraryDomain.Models;
using System.Collections.Generic;

namespace LibraryClient.Mapper
{
    public static class Mapper
    {
        public static IEnumerable<DocumentCardInfo> MapToDocumentCardInfoList(IEnumerable<Document> documents)
        {
            var documentsCardInfos = new List<DocumentCardInfo>();

            foreach (var document in documents)
            {
                var cardInfo = new DocumentCardInfo()
                {
                    //Id = document.Id,
                    //Title = document.Title ?? "N/A",
                    //DocumentType = document.DocumentType,
                    //DatePublished = document.DatePublished ?? "N/A",
                    //ISBN = document.ISBN ?? "N/A",
                    //Authors = document.Authors ?? new List<string>() { "N/A" },
                    //NumberOfPages = document.NumberOfPages,
                    //Publisher = document.Publisher ?? "N/A",
                    //OriginalPublisher = document.OriginalPublisher ?? "N/A",
                    //CountryOfLocalization = document.CountryOfLocalization,
                    //LocalPublisher = document.LocalPublisher ?? "N/A",
                    //ExpirationDate = document.ExpirationDate ?? "N/A",
                };
                documentsCardInfos.Add(cardInfo);
            }

            return documentsCardInfos;
        }

        public static Book MapToBook(BookCardInfo bookCardInfo)
        {
            return new Book()
            {
                Id = bookCardInfo.Id,
                Title = bookCardInfo.Title,
                DocumentType = bookCardInfo.DocumentType,
                DatePublished = bookCardInfo.DatePublished,
                ISBN = bookCardInfo.ISBN,
                Authors = bookCardInfo.Authors,
                NumberOfPages = bookCardInfo.NumberOfPages,
                Publisher = bookCardInfo.Publisher,
            };
        }

        public static LocalizedBook MapToLocalizedBook(LocalizedBookCardInfo localizedBookCardInfo)
        {
            return new LocalizedBook()
            {
                Id = localizedBookCardInfo.Id,
                Title = localizedBookCardInfo.Title,
                DocumentType = localizedBookCardInfo.DocumentType,
                DatePublished = localizedBookCardInfo.DatePublished,
                ISBN = localizedBookCardInfo.ISBN,
                Authors = localizedBookCardInfo.Authors,
                NumberOfPages = localizedBookCardInfo.NumberOfPages,
                OriginalPublisher = localizedBookCardInfo.OriginalPublisher,
                CountryOfLocalization = localizedBookCardInfo.CountryOfLocalization,
                LocalPublisher = localizedBookCardInfo.LocalPublisher,
            };
        }

        public static Magazine MapToMagazine(MagazineCardInfo magazineCardInfo)
        {
            return new Magazine()
            {
                Id = magazineCardInfo.Id,
                Title = magazineCardInfo.Title,
                DocumentType = magazineCardInfo.DocumentType,
                DatePublished = magazineCardInfo.DatePublished,
                Publisher = magazineCardInfo.Publisher,
                ReleaseNumber = magazineCardInfo.ReleaseNumber,
            };
        }

        public static Patent MapToPatent(PatentCardInfo patentCardInfo)
        {
            return new Patent()
            {
                Id = patentCardInfo.Id,
                Title = patentCardInfo.Title,
                DocumentType = patentCardInfo.DocumentType,
                DatePublished = patentCardInfo.DatePublished,
                Authors = patentCardInfo.Authors,
                ExpirationDate = patentCardInfo.ExpirationDate,
                UniqueId = patentCardInfo.UniqueId,
            };
        }
    }
}
