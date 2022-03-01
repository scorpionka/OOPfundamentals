using LibraryClient.Models;
using LibraryClient.PresentationServices.Interfaces;
using LibraryDomain.DomainServices.Interfaces;

namespace LibraryClient.PresentationServices
{
    public class BookPresentationService : IBookPresentationService
    {
        private readonly IBookDomainService bookDomainService;

        public BookPresentationService(IBookDomainService bookDomainService)
        {
            this.bookDomainService = bookDomainService;
        }

        public bool AddBookCardInfo(BookCardInfo bookCardInfo)
        {
            return bookDomainService.AddBook(Mapper.Mapper.MapToBook(bookCardInfo));
        }
    }
}
