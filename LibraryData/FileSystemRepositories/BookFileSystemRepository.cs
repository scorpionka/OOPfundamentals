using LibraryDomain.Models;
using LibraryDomain.Repositories.Interfaces;

namespace LibraryData.FileSystemRepositories
{
    public class BookFileSystemRepository : IBookRepository
    {
        public bool AddBook(Book book)
        {
            try
            {
                Serializers.JsonSerializerTool<Book>.SerializeDocument(book, book.Id);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
