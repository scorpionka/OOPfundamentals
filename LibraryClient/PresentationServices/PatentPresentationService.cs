using LibraryClient.Models;
using LibraryClient.PresentationServices.Interfaces;
using LibraryDomain.DomainServices.Interfaces;

namespace LibraryClient.PresentationServices
{
    public class PatentPresentationService : IPatentPresentationService
    {
        private readonly IPatentDomainService patentDomainService;

        public PatentPresentationService(IPatentDomainService patentDomainService)
        {
            this.patentDomainService = patentDomainService;
        }

        public bool AddPatentCardInfo(PatentCardInfo patentCardInfo)
        {
            return patentDomainService.AddPatent(Mapper.Mapper.MapToPatent(patentCardInfo));
        }
    }
}
