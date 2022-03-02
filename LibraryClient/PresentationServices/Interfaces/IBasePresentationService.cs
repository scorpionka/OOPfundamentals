using LibraryClient.Models;
using System.Collections.Generic;

namespace LibraryClient.PresentationServices.Interfaces
{
    public interface IBasePresentationService
    {
        public IEnumerable<DocumentCardInfo> GetDocumentCardInfos(int id);
    }
}
