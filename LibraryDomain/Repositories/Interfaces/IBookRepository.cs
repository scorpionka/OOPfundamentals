using LibraryDomain.Models;

namespace LibraryDomain.Repositories.Interfaces
{
    public interface IBookRepository
    {
        public bool AddBook(Book book);
    }
}
