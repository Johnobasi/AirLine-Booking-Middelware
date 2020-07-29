using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GreenAfrica_API.Data;
using GreenAfrica_API.Repo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace GreenAfrica_API.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class FlightInfoController : ControllerBase
    {
        private readonly AIMSDATAContext _context;
        private readonly ICpayroll _payroll;

        public FlightInfoController(AIMSDATAContext context, ICpayroll payroll)
        {
            _context = context;
            _payroll = payroll;
        }

        // GET: api/FlightInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FlightInfo>>> GetFlightInfo()
        {
            return await _context.FlightInfo.ToListAsync();
        }

        // GET: api/FlightInfo/5
        [HttpGet("{flight}")]
        public IEnumerable<FlightInfo> FlightInfo([FromQuery]string flightNumber)
        {
            var results = _payroll.GetById(flightNumber);
            return results;
        }

        // PUT: api/FlightInfo/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlightInfo(int id, FlightInfo flightInfo)
        {
            if (id != flightInfo.FlightId)
            {
                return BadRequest();
            }

            _context.Entry(flightInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlightInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/FlightInfo
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FlightInfo>> PostFlightInfo(FlightInfo flightInfo)
        {
            _context.FlightInfo.Add(flightInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFlightInfo", new { id = flightInfo.FlightId }, flightInfo);
        }

        // DELETE: api/FlightInfo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FlightInfo>> DeleteFlightInfo(int id)
        {
            var flightInfo = await _context.FlightInfo.FindAsync(id);
            if (flightInfo == null)
            {
                return NotFound();
            }

            _context.FlightInfo.Remove(flightInfo);
            await _context.SaveChangesAsync();

            return flightInfo;
        }

        private bool FlightInfoExists(int id)
        {
            return _context.FlightInfo.Any(e => e.FlightId == id);
        }
    }
}
