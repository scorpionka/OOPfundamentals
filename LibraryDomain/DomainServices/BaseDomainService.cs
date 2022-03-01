using LibraryDomain.DomainServices.Interfaces;
using LibraryDomain.Models;
using LibraryDomain.Repositories.Interfaces;
using System.Collections.Generic;

namespace LibraryDomain.DomainServices
{
    public class BaseDomainService : IBaseDomainService
    {
        private readonly IBaseRepository baseRepository;

        public BaseDomainService(IBaseRepository baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public IEnumerable<Document> GetDocuments()
        {
            return baseRepository.GetDocuments();
        }
    }
}
