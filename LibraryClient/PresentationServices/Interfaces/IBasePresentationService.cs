using LibraryClient.Models;
using LibraryDomain.Models;
using System.Collections.Generic;

namespace LibraryClient.PresentationServices.Interfaces
{
    public interface IBasePresentationService
    {
        public List<DocumentCardInfo> GetDocumentCardInfos();
        public bool AddDocumentCardInfo(DocumentCardInfo documentCardInfo);
    }
}
