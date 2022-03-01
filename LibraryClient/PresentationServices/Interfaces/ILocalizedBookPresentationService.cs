using LibraryClient.Models;

namespace LibraryClient.PresentationServices.Interfaces
{
    public interface ILocalizedBookPresentationService
    {
        public bool AddLocalizedBookCardInfo(LocalizedBookCardInfo localizedBookCardInfo);
    }
}
