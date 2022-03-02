using LibraryDomain.DomainServices.Interfaces;
using LibraryDomain.Models;
using LibraryDomain.Repositories.Interfaces;

namespace LibraryDomain.DomainServices
{
    public class BookDomainService : IBookDomainService
    {
        private readonly IBookRepository bookRepository;

        public BookDomainService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public bool AddBook(Book book)
        {
            return bookRepository.AddBook(book);
        }
    }
}
