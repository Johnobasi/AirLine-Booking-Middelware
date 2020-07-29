using GreenAfrica_API.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GreenAfrica_API.Repo
{
    public class CpayrollService : ICpayroll
    {
        private readonly AIMSDATAContext _context;
        public CpayrollService(AIMSDATAContext context)
        {
            _context = context;
        }
        public IEnumerable<Cpayroll> GetAll()
        {
            return _context.Cpayroll;
        }



        //public Cpayroll GetByFlightDate(DateTime startDate, DateTime endDate)
        //{
        //    var results = _context.Cpayroll.Where(x => x.FlightDate >= startDate && x.FlightDate <= endDate).ToList();
        //    return results;
        //}

        IEnumerable<Cpayroll> ICpayroll.GetByFlightDate(DateTime startDate, DateTime endDate)
        {
            var results = _context.Cpayroll.Where(x => x.FlightDate >= startDate && x.FlightDate <= endDate).ToList();
            return results;
        }


        //public FlightInfo GetById(string flightNumber)
        //{
        //    return _context.FlightInfo.Where(d => d.FlightNo == flightNumber).FirstOrDefault();
        //}

        IEnumerable<FlightInfo> ICpayroll.GetById(string flightNumber)
        {
            var test = _context.FlightInfo.Where(d => d.FlightNo == flightNumber).ToList();
            return test;
        }
    }
}
