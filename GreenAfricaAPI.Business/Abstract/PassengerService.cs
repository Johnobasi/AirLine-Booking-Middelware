using System;
using System.Collections.Generic;
using System.Text;

namespace GreenAfricaAPI.Business.Abstract
{
    public class PassengerService : IPassengers
    {
        private readonly GreenAPIDbContext _greenAPIDbContext;
        public PassengerService(GreenAPIDbContext greenAPIDbContext)
        {
            _greenAPIDbContext = greenAPIDbContext;
        }
    }
}
