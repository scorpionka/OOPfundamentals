using LibraryDomain.Models;
using LibraryDomain.Repositories.Interfaces;

namespace LibraryData.FileSystemRepositories
{
    public class PatentFileSystemRepository : IPatentRepository
    {
        public bool AddPatent(Patent patent)
        {
            try
            {
                Serializers.JsonSerializerTool<Patent>.SerializeDocument(patent, patent.Id);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
