using LibraryDomain.Models;

namespace LibraryDomain.Repositories.Interfaces
{
    public interface IMagazineRepository
    {
        public bool AddMagazine(Magazine magazine);
    }
}
