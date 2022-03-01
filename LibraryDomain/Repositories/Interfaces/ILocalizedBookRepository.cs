using LibraryDomain.Models;

namespace LibraryDomain.Repositories.Interfaces
{
    public interface ILocalizedBookRepository
    {
        public bool AddLocalizedBook(LocalizedBook localizedBook);
    }
}
