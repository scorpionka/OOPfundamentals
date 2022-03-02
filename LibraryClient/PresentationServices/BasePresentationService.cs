using LibraryClient.Models;
using LibraryClient.PresentationServices.Interfaces;
using LibraryDomain.DomainServices.Interfaces;
using System.Collections.Generic;

namespace LibraryClient.PresentationServices
{
    public class BasePresentationService : IBasePresentationService
    {
        private readonly IBaseDomainService baseDomainService;

        public BasePresentationService(IBaseDomainService baseDomainService)
        {
            this.baseDomainService = baseDomainService;
        }

        public IEnumerable<DocumentCardInfo> GetDocumentCardInfos(int id)
        {
            var documents = baseDomainService.GetDocuments(id);
            return Mapper.Mapper.MapToDocumentCardInfoList(documents);
        }
    }
}
