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

            //var listOfCardInfo = basePresentationService.GetDocumentCardInfos();

            //foreach (var cardInfo in listOfCardInfo)
            //{
            //    Console.WriteLine($"Id: {cardInfo.Id}");
            //    Console.WriteLine($"Type: {cardInfo.DocumentType}");
            //    Console.WriteLine($"Title: {cardInfo.Title}");
            //    Console.WriteLine($"ISBN: {cardInfo.ISBN}");
            //    Console.WriteLine($"Date published: {cardInfo.DatePublished}");
            //    foreach (var author in cardInfo.Authors)
            //    {
            //        Console.WriteLine("Authors:");
            //        Console.WriteLine(author);
            //    }
            //    Console.WriteLine($"Number of pages: {cardInfo.NumberOfPages}");
            //    Console.WriteLine($"Publisher: {cardInfo.Publisher}");
            //    Console.WriteLine($"Local publisher: {cardInfo.LocalPublisher}");
            //    Console.WriteLine($"Original publisher: {cardInfo.OriginalPublisher}");
            //    Console.WriteLine($"Country of localization: {cardInfo.CountryOfLocalization}");
            //    Console.WriteLine($"Expiration date: {cardInfo.ExpirationDate}");
            //}
        }
    }
}
