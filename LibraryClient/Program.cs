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

        public Program(IBasePresentationService basePresentationService)
        {
            this.basePresentationService = basePresentationService;
        }

        static void Main(string[] args)
        {
            ProgramServicesProvider.RunServicesProvider(args);
        }

        public void Run()
        {
            var documentCardInfo = new DocumentCardInfo()
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

            basePresentationService.AddDocumentCardInfo(documentCardInfo);

            var documentCardInfo1 = new DocumentCardInfo()
            {
                Id = 2,
                Title = "War and Peace",
                DocumentType = DocumentType.Book,
                DatePublished = new DateTime(2021, 1, 1).ToString("yyyy-MM-dd"),
                ISBN = "1245-8-4380",
                Authors = new List<string>() { "Lev Tolstoy" },
                NumberOfPages = 900,
                Publisher = "MoscowIzdat",
            };

            basePresentationService.AddDocumentCardInfo(documentCardInfo1);

            var documentCardInfo2 = new DocumentCardInfo()
            {
                Id = 3,
                Title = "Wheel",
                DocumentType = DocumentType.Patent,
                DatePublished = new DateTime(2000, 1, 1).ToString("yyyy-MM-dd"),
                Authors = new List<string>() { "Human" },
                ExpirationDate = new DateTime(7000, 1, 1).ToString("yyyy-MM-dd"),
            };

            basePresentationService.AddDocumentCardInfo(documentCardInfo2);

            var listOfCardInfo = basePresentationService.GetDocumentCardInfos();

            foreach (var cardInfo in listOfCardInfo)
            {
                Console.WriteLine($"Id: {cardInfo.Id}");
                Console.WriteLine($"Type: {cardInfo.DocumentType}");
                Console.WriteLine($"Title: {cardInfo.Title}");
                Console.WriteLine($"ISBN: {cardInfo.ISBN}");
                Console.WriteLine($"Date published: {cardInfo.DatePublished}");
                foreach (var author in cardInfo.Authors)
                {
                    Console.WriteLine("Authors:");
                    Console.WriteLine(author);
                }
                Console.WriteLine($"Number of pages: {cardInfo.NumberOfPages}");
                Console.WriteLine($"Publisher: {cardInfo.Publisher}");
                Console.WriteLine($"Local publisher: {cardInfo.LocalPublisher}");
                Console.WriteLine($"Original publisher: {cardInfo.OriginalPublisher}");
                Console.WriteLine($"Country of localization: {cardInfo.CountryOfLocalization}");
                Console.WriteLine($"Expiration date: {cardInfo.ExpirationDate}");
            }
        }
    }
}
