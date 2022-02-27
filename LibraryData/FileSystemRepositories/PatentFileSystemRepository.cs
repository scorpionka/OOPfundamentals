using LibraryDomain.Models;
using LibraryDomain.Repositories;

namespace LibraryData.FileSystemRepositories
{
    public class PatentFileSystemRepository : BaseFileSystemRepository<Patent>, IPatentRepository
    {
    }
}
