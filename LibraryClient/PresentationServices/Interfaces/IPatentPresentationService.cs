using LibraryClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClient.PresentationServices.Interfaces
{
    public interface IPatentPresentationService
    {
        public bool AddPatentCardInfo(PatentCardInfo patentCardInfo);
    }
}
