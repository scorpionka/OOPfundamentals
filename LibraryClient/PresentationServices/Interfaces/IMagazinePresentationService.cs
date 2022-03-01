using LibraryClient.Models;

namespace LibraryClient.PresentationServices.Interfaces
{
    public interface IMagazinePresentationService
    {
        public bool AddMagazineCardInfo(MagazineCardInfo magazineCardInfo);
    }
}
