using System;
using System.Collections;
using System.Collections.Generic;
using GreenAfrica_API.Data;
using GreenAfrica_API.Options;
using GreenAfrica_API.Repo;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GreenAfrica_API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CPayrollController : ControllerBase
    {
        private readonly ICpayroll _payroll;
        private readonly AIMSDATAContext _context;
      
        public CPayrollController(ICpayroll payroll, AIMSDATAContext context)
        {
            _payroll = payroll;
            _context = context;
        }

        // GET: api/CPayroll
        [HttpGet]
        //[Authorize(Policy = Policies.Admin)]
        public IActionResult AllPayroll()
        {
            var AllPay = _payroll.GetAll();
            return Ok(AllPay);
        }

        //[HttpGet("{datetime}")]
        //public IActionResult CrewPayroll(DateTime startDate, DateTime endDate)
        //{
        //    var results = _context.Cpayroll.Where(x => x.FlightDate >= startDate && x.FlightDate <= endDate).ToList();
        //    return Ok(results);
        //}

        [HttpGet("data")]
        public IEnumerable<Cpayroll> CrewPayroll([FromQuery]DateTime startDate, [FromQuery]DateTime endDate)
        {
            var allDate = _payroll.GetByFlightDate(startDate, endDate);

            return allDate;

        }
    }
}
