using LibraryDomain.Models;

namespace LibraryDomain.DomainServices.Interfaces
{
    public interface IBookDomainService
    {
        public bool AddBook(Book book);
    }
}
