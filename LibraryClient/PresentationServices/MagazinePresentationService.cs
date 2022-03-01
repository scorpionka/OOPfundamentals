using LibraryClient.Models;
using LibraryClient.PresentationServices.Interfaces;
using LibraryDomain.DomainServices.Interfaces;

namespace LibraryClient.PresentationServices
{
    public class MagazinePresentationService : IMagazinePresentationService
    {
        private readonly IMagazineDomainService magazineDomainService;

        public MagazinePresentationService(IMagazineDomainService magazineDomainService)
        {
            this.magazineDomainService = magazineDomainService;
        }

        public bool AddMagazineCardInfo(MagazineCardInfo magazineCardInfo)
        {
            return magazineDomainService.AddMagazine(Mapper.Mapper.MapToMagazine(magazineCardInfo));
        }
    }
}
