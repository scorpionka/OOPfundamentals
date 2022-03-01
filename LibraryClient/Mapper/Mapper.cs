using LibraryClient.Models;
using LibraryDomain.Models;
using System;
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
            if (bookCardInfo == null)
            {
                throw new ArgumentNullException(nameof(bookCardInfo));
            }

            return new Book()
            {
                Id = bookCardInfo.Id,
                Title = bookCardInfo.Title ?? "N/A",
                DocumentType = bookCardInfo.DocumentType,
                DatePublished = bookCardInfo.DatePublished ?? "N/A",
                ISBN = bookCardInfo.ISBN ?? "N/A",
                Authors = bookCardInfo.Authors ?? new List<string>() { "N/A" },
                NumberOfPages = bookCardInfo.NumberOfPages,
                Publisher = bookCardInfo.Publisher ?? "N/A",
            };
        }

        public static LocalizedBook MapToLocalizedBook(LocalizedBookCardInfo localizedBookCardInfo)
        {
            if (localizedBookCardInfo == null)
            {
                throw new ArgumentNullException(nameof(localizedBookCardInfo));
            }

            return new LocalizedBook()
            {
                Id = localizedBookCardInfo.Id,
                Title = localizedBookCardInfo.Title ?? "N/A",
                DocumentType = localizedBookCardInfo.DocumentType,
                DatePublished = localizedBookCardInfo.DatePublished ?? "N/A",
                ISBN = localizedBookCardInfo.ISBN ?? "N/A",
                Authors = localizedBookCardInfo.Authors ?? new List<string>() { "N/A" },
                NumberOfPages = localizedBookCardInfo.NumberOfPages,
                OriginalPublisher = localizedBookCardInfo.OriginalPublisher ?? "N/A",
                CountryOfLocalization = localizedBookCardInfo.CountryOfLocalization,
                LocalPublisher = localizedBookCardInfo.LocalPublisher ?? "N/A",
            };
        }

        public static Magazine MapToMagazine(MagazineCardInfo magazineCardInfo)
        {
            if (magazineCardInfo == null)
            {
                throw new ArgumentNullException(nameof(magazineCardInfo));
            }

            return new Magazine()
            {
                Id = magazineCardInfo.Id,
                Title = magazineCardInfo.Title ?? "N/A",
                DocumentType = magazineCardInfo.DocumentType,
                DatePublished = magazineCardInfo.DatePublished ?? "N/A",
                Publisher = magazineCardInfo.Publisher ?? "N/A",
                ReleaseNumber = magazineCardInfo.ReleaseNumber,
            };
        }

        public static Patent MapToPatent(PatentCardInfo patentCardInfo)
        {
            if (patentCardInfo == null)
            {
                throw new ArgumentNullException(nameof(patentCardInfo));
            }

            return new Patent()
            {
                Id = patentCardInfo.Id,
                Title = patentCardInfo.Title ?? "N/A",
                DocumentType = patentCardInfo.DocumentType,
                DatePublished = patentCardInfo.DatePublished ?? "N/A",
                Authors = patentCardInfo.Authors ?? new List<string>() { "N/A" },
                ExpirationDate = patentCardInfo.ExpirationDate ?? "N/A",
                UniqueId = patentCardInfo.UniqueId,
            };
        }
    }
}
