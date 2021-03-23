using GreenAfrica.DataAccess.Models;
using GreenAfricaAPI.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenAfrica_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITickets _ticketsRepo;

        public TicketsController(ITickets ticketsRepo)
        {
            _ticketsRepo = ticketsRepo;
        }

        public IActionResult GetAll()
        {
            return Ok();
        }
    }
}
