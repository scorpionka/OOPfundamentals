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
                DatePublished = new DateTime(2022, 1, 1),
                ISBN = "1245-8-7989",
                Authors = new List<string>() { "Walter Scott" },
                NumberOfPages = 400,
                Publisher = "SamIzdat",
            };

            basePresentationService.AddDocumentCardInfo(documentCardInfo);

            var listOfCardInfo = basePresentationService.GetDocumentCardInfos();

            foreach (var cardInfo in listOfCardInfo)
            {
                Console.WriteLine($"Id: {cardInfo.Id}");
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
