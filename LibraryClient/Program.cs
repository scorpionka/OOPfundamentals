using LibraryClient.Models;
using LibraryClient.PresentationServices.Interfaces;
using LibraryDomain.Models;
using System;
using System.Collections.Generic;

namespace LibraryClient
{
    public class Program
    {
        private readonly IBasePresentationService basePresentationService;
        private readonly IBookPresentationService bookPresentationService;
        private readonly ILocalizedBookPresentationService localizedBookPresentationService;
        private readonly IMagazinePresentationService magazinePresentationService;
        private readonly IPatentPresentationService patentPresentationService;

        public Program(
            IBasePresentationService basePresentationService,
            IBookPresentationService bookPresentationService,
            ILocalizedBookPresentationService localizedBookPresentationService,
            IMagazinePresentationService magazinePresentationService,
            IPatentPresentationService patentPresentationService
            )
        {
            this.basePresentationService = basePresentationService;
            this.bookPresentationService = bookPresentationService;
            this.localizedBookPresentationService = localizedBookPresentationService;
            this.magazinePresentationService = magazinePresentationService;
            this.patentPresentationService = patentPresentationService;
        }

        static void Main(string[] args)
        {
            ProgramServicesProvider.RunServicesProvider(args);
        }

        public void Run()
        {
            var bookCardInfo = new BookCardInfo()
            {
                Id = 1,
                Title = "Ivanhoe",
                DocumentType = DocumentType.Book,
                DatePublished = new DateTime(2022, 1, 1).ToString("yyyy-MM-dd"),
                ISBN = "1245-8-7989",
                Authors = new List<string>() { "Walter Scott" },
                NumberOfPages = 400,
                Publisher = "SamIzdat",
            };

            bookPresentationService.AddBookCardInfo(bookCardInfo);

            var bookCardInfo1 = new BookCardInfo()
            {
                Id = 3,
                Title = "World War II",
                DocumentType = DocumentType.Book,
                DatePublished = new DateTime(1995, 9, 17).ToString("yyyy-MM-dd"),
                ISBN = "1546-8-7911",
                Authors = new List<string>() { "Winston Churchill" },
                NumberOfPages = 1500,
                Publisher = "London Publishing Office",
            };

            bookPresentationService.AddBookCardInfo(bookCardInfo1);

            var localizedBookCardInfo = new LocalizedBookCardInfo()
            {
                Id = 2,
                Title = "War and Peace",
                DocumentType = DocumentType.LocalizedBook,
                DatePublished = new DateTime(2021, 1, 1).ToString("yyyy-MM-dd"),
                ISBN = "1245-8-4380",
                Authors = new List<string>() { "Lev Tolstoy" },
                NumberOfPages = 900,
                OriginalPublisher = "MoscowIzdat",
                CountryOfLocalization = Country.USA,
                LocalPublisher = "Smith Publishing Office",
            };

            localizedBookPresentationService.AddLocalizedBookCardInfo(localizedBookCardInfo);

            var patentCardInfo = new PatentCardInfo()
            {
                Id = 3,
                Title = "Wheel",
                DocumentType = DocumentType.Patent,
                DatePublished = new DateTime(2000, 1, 1).ToString("yyyy-MM-dd"),
                Authors = new List<string>() { "Human" },
                ExpirationDate = new DateTime(7000, 1, 1).ToString("yyyy-MM-dd"),
                UniqueId = 1000,
            };

            patentPresentationService.AddPatentCardInfo(patentCardInfo);

            var patentCardInfo1 = new PatentCardInfo()
            {
                Id = 4,
                Title = "Fire",
                DocumentType = DocumentType.Patent,
                DatePublished = new DateTime(1999, 11, 11).ToString("yyyy-MM-dd"),
                Authors = new List<string>() { "Human" },
                ExpirationDate = new DateTime(7000, 1, 1).ToString("yyyy-MM-dd"),
                UniqueId = 2000,
            };

            patentPresentationService.AddPatentCardInfo(patentCardInfo1);

            var magazineCardInfo = new MagazineCardInfo()
            {
                Id = 4,
                Title = "Science",
                DocumentType = DocumentType.Magazine,
                DatePublished = new DateTime(2010, 10, 10).ToString("yyyy-MM-dd"),
                ReleaseNumber = 4099,
                Publisher = "American Association for the Advancement of Science",
            };

            magazinePresentationService.AddMagazineCardInfo(magazineCardInfo);

            var listOfCardInfo1 = basePresentationService.GetDocumentCardInfos(1);
            var listOfCardInfo2 = basePresentationService.GetDocumentCardInfos(2);
            var listOfCardInfo3 = basePresentationService.GetDocumentCardInfos(3);
            var listOfCardInfo4 = basePresentationService.GetDocumentCardInfos(4);
            var listOfCardInfo5 = basePresentationService.GetDocumentCardInfos(5);
        }
    }
}
