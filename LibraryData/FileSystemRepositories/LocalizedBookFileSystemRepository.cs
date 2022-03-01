using LibraryDomain.Models;
using LibraryDomain.Repositories.Interfaces;

namespace LibraryData.FileSystemRepositories
{
    public class LocalizedBookFileSystemRepository : ILocalizedBookRepository
    {
        public bool AddLocalizedBook(LocalizedBook localizedBook)
        {
            try
            {
                Serializers.JsonSerializerTool<LocalizedBook>.SerializeDocument(localizedBook, localizedBook.Id);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
