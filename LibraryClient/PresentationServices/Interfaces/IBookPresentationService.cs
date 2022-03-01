using LibraryClient.Models;

namespace LibraryClient.PresentationServices.Interfaces
{
    public interface IBookPresentationService
    {
        public bool AddBookCardInfo(BookCardInfo bookCardInfo);
    }
}
