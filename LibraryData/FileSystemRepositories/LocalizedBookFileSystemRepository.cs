using LibraryDomain.Models;
using LibraryDomain.Repositories;

namespace LibraryData.FileSystemRepositories
{
    public class LocalizedBookFileSystemRepository : BaseFileSystemRepository<LocalizedBook>, ILocalizedBookRepository
    {
    }
}
