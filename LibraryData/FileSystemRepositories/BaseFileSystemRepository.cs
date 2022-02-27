using LibraryDomain.Repositories;

namespace LibraryData.FileSystemRepositories
{
    public class BaseFileSystemRepository<T> : IBaseRepository<T> where T : class
    {
    }
}
