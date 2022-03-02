using LibraryDomain.Models;

namespace LibraryDomain.DomainServices.Interfaces
{
    public interface IPatentDomainService
    {
        public bool AddPatent(Patent patent);
    }
}
