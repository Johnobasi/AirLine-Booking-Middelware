using GreenAfrica.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GreenAfricaAPI.Business.Abstract
{
    public interface IPassengers
    {
        Task<IEnumerable<Passenger>> GetAll();
        Task <Passenger> Get(int id);
        Task<bool> CreatePassenger(Passenger request);
        Task<bool> UpdatePassenger(Passenger request);
        Task<bool> DeletePassenger(int id);
    }
}
