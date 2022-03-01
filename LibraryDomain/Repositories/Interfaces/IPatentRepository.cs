using LibraryDomain.Models;

namespace LibraryDomain.Repositories.Interfaces
{
    public interface IPatentRepository
    {
        public bool AddPatent(Patent patent);
    }
}
