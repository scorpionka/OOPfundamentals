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
                switch (document.DocumentType)
                {
                    case DocumentType.Book:
                        var book = document as Book;
                        var bookCardInfo = new BookCardInfo()
                        {
                            Id = book.Id,
                            Title = book.Title,
                            DocumentType = book.DocumentType,
                            DatePublished = book.DatePublished,
                            ISBN = book.ISBN,
                            Authors = book.Authors,
                            NumberOfPages = book.NumberOfPages,
                            Publisher = book.Publisher,
                        };
                        documentsCardInfos.Add(bookCardInfo);
                        break;
                    case DocumentType.LocalizedBook:
                        var localizedBook = document as LocalizedBook;
                        var localizedBookCardInfo = new LocalizedBookCardInfo()
                        {
                            Id = localizedBook.Id,
                            Title = localizedBook.Title,
                            DocumentType = localizedBook.DocumentType,
                            DatePublished = localizedBook.DatePublished,
                            ISBN = localizedBook.ISBN,
                            Authors = localizedBook.Authors,
                            NumberOfPages = localizedBook.NumberOfPages,
                            OriginalPublisher = localizedBook.OriginalPublisher,
                            CountryOfLocalization = localizedBook.CountryOfLocalization,
                            LocalPublisher = localizedBook.LocalPublisher,
                        };
                        documentsCardInfos.Add(localizedBookCardInfo);
                        break;
                    case DocumentType.Magazine:
                        var magazine = document as Magazine;
                        var magazineCardInfo = new MagazineCardInfo()
                        {
                            Id = magazine.Id,
                            Title = magazine.Title,
                            DocumentType = magazine.DocumentType,
                            DatePublished = magazine.DatePublished,
                            Publisher = magazine.Publisher,
                            ReleaseNumber = magazine.ReleaseNumber,
                        };
                        documentsCardInfos.Add(magazineCardInfo);
                        break;
                    case DocumentType.Patent:
                        var patent = document as Patent;
                        var patentCardInfo = new PatentCardInfo()
                        {
                            Id = patent.Id,
                            Title = patent.Title,
                            DocumentType = patent.DocumentType,
                            DatePublished = patent.DatePublished,
                            Authors = patent.Authors,
                            ExpirationDate = patent.ExpirationDate,
                            UniqueId = patent.UniqueId,
                        };
                        documentsCardInfos.Add(patentCardInfo);
                        break;
                    default:
                        break;
                }
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
