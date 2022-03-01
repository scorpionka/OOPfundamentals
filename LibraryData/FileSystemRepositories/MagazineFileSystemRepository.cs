using LibraryDomain.Models;
using LibraryDomain.Repositories.Interfaces;

namespace LibraryData.FileSystemRepositories
{
    public class MagazineFileSystemRepository : IMagazineRepository
    {
        public bool AddMagazine(Magazine magazine)
        {
            try
            {
                Serializers.JsonSerializerTool<Magazine>.SerializeDocument(magazine, magazine.Id);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
