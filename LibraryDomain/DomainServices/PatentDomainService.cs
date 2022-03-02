using LibraryDomain.DomainServices.Interfaces;
using LibraryDomain.Models;
using LibraryDomain.Repositories.Interfaces;

namespace LibraryDomain.DomainServices
{
    public class PatentDomainService : IPatentDomainService
    {
        private readonly IPatentRepository patentRepository;

        public PatentDomainService(IPatentRepository patentRepository)
        {
            this.patentRepository = patentRepository;
        }

        public bool AddPatent(Patent patent)
        {
            return patentRepository.AddPatent(patent);
        }
    }
}
