using LibraryDomain.Models;
using LibraryDomain.Repositories;

namespace LibraryData.FileSystemRepositories
{
    public class BookFileSystemRepository : BaseFileSystemRepository<Book>, IBookRepository
    {
    }
}
