using GreenAfricaAPI.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreenAfrica_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaasengersController : ControllerBase
    {
        private readonly IPassengers _passengerRepository;

        public PaasengersController(IPassengers passengerRepository)
        {
            _passengerRepository = passengerRepository;
        }

        // GET: api/<PaasengersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PaasengersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PaasengersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PaasengersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PaasengersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
