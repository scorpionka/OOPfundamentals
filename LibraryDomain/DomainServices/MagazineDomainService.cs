using LibraryDomain.DomainServices.Interfaces;
using LibraryDomain.Models;
using LibraryDomain.Repositories.Interfaces;

namespace LibraryDomain.DomainServices
{
    public class MagazineDomainService : IMagazineDomainService
    {
        private readonly IMagazineRepository magazineRepository;

        public MagazineDomainService(IMagazineRepository magazineRepository)
        {
            this.magazineRepository = magazineRepository;
        }

        public bool AddMagazine(Magazine magazine)
        {
            return magazineRepository.AddMagazine(magazine);
        }
    }
}
