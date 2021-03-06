using System.Collections;
using System.Collections.Generic;
using Models;

namespace WebApplication.Data.Impl.Adults
{
    public interface IAdults
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
        void RemoveAdult(int adultId);
        void Update(Adult adult);
        Adult Get(int id);
    }
}