using LibraryDomain.Models;

namespace LibraryDomain.DomainServices.Interfaces
{
    public interface ILocalizedBookDomainService
    {
        public bool AddLocalizedBook(LocalizedBook localizedBook);
    }
}
