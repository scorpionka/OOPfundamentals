using LibraryDomain.DomainServices.Interfaces;
using LibraryDomain.Models;
using LibraryDomain.Repositories.Interfaces;

namespace LibraryDomain.DomainServices
{
    public class LocalizedBookDomainService : ILocalizedBookDomainService
    {
        private readonly ILocalizedBookRepository localizedBookRepository;

        public LocalizedBookDomainService(ILocalizedBookRepository localizedBookRepository)
        {
            this.localizedBookRepository = localizedBookRepository;
        }

        public bool AddLocalizedBook(LocalizedBook localizedBook)
        {
            return localizedBookRepository.AddLocalizedBook(localizedBook);
        }
    }
}
