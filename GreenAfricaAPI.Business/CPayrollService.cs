using GreenAfrica.DataAccess;
using GreenAfrica.DataAccess.Models;
using GreenAfricaAPI.Business.Abstract;
using System;
using System.Collections.Generic;

namespace GreenAfricaAPI.Business
{
    public class CPayrollService : ICPayroll
    {
        private readonly GreenAPIDbContext _context;

        public CPayrollService(GreenAPIDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CPayroll> GetAll()
        {
            return _context.Cpayroll;
        }
    }
}
