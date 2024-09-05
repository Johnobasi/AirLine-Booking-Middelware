using GreenAfrica_API.Dtos;
using GreenAfricaAPI.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreenAfrica_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IPassengers _passengerRepository;

        public CustomerController(IPassengers passengerRepository)
        {
            _passengerRepository = passengerRepository;
        }

        [HttpGet]
        public IEnumerable<string> GetPassengers()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var passengers = await _passengerRepository.Get(id);
            if (passengers == null) { return NotFound(); }
            else { return Ok(passengers); }
        }


        [HttpPost]
        public void CreatePassenger([FromBody] PassengerDTO request)
        {
        }

        [HttpPut("{id}")]
        public void UpdatePassenger(int id, [FromBody] string value)
        {
        }
        
        [HttpDelete("{id}")]
        public void DeletePassenger(int id)
        {
        }
    }
}
