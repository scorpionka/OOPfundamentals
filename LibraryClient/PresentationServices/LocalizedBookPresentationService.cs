using LibraryClient.Models;
using LibraryClient.PresentationServices.Interfaces;
using LibraryDomain.DomainServices.Interfaces;

namespace LibraryClient.PresentationServices
{
    public class LocalizedBookPresentationService : ILocalizedBookPresentationService
    {
        private readonly ILocalizedBookDomainService localizedBookDomainService;

        public LocalizedBookPresentationService(ILocalizedBookDomainService localizedBookDomainService)
        {
            this.localizedBookDomainService = localizedBookDomainService;
        }

        public bool AddLocalizedBookCardInfo(LocalizedBookCardInfo localizedBookCardInfo)
        {
            return localizedBookDomainService.AddLocalizedBook(Mapper.Mapper.MapToLocalizedBook(localizedBookCardInfo));
        }
    }
}
