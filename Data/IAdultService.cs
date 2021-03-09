using System.Collections.Generic;
using Models;

namespace WebApplication7.Data
{
    public interface IAdultService
    {
        IList<Adult> getAdults();
        void AddAdult(Adult adult);
        void RemoveAdult(int adultID);
        
    }
}