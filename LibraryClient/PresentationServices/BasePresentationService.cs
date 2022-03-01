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

        public bool AddDocumentCardInfo(DocumentCardInfo documentCardInfo)
        {
            return baseDomainService.AddDocument(Mapper.Mapper.MapToDocument(documentCardInfo));
        }

        public IEnumerable<DocumentCardInfo> GetDocumentCardInfos()
        {
            var documents = baseDomainService.GetDocuments();
            return Mapper.Mapper.MapToDocumentCardInfoList(documents);
        }
    }
}
