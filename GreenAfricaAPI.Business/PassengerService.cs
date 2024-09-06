using GreenAfrica.DataAccess;
using GreenAfrica.DataAccess.Models;
using GreenAfricaAPI.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GreenAfricaAPI.Business.Repository
{
    public class PassengerService : IPassengers
    {
        private readonly GreenAPIDbContext _greenAPIDbContext;
        public PassengerService(GreenAPIDbContext greenAPIDbContext)
        {
            _greenAPIDbContext = greenAPIDbContext;
        }

        public Task<bool> CreatePassenger(Passenger payload)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePassenger(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Passenger> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Passenger>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePassenger(Passenger payload)
        {
            throw new NotImplementedException();
        }
    }
}
