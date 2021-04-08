using GreenAfrica.DataAccess;
using GreenAfrica.DataAccess.Models;
using GreenAfricaAPI.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenAfricaAPI.Business
{
    public class FleetService : IFleet
    {
        private readonly GreenAPIDbContext _context;
        public FleetService(GreenAPIDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Fleet> GetAll()
        {
            return _context.Fleets;
        }

        public Fleet GetById(int Id)
        {
            return _context.Fleets.Where(c => c.Id == Id).FirstOrDefault();
        }
    }
}
