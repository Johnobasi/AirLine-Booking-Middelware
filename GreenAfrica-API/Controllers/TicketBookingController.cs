using GreenAfricaAPI.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace GreenAfrica_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketBookingController : ControllerBase
    {
        private readonly ITicketBookingService _iTicketBookingService;

        public TicketBookingController(ITicketBookingService iTicketBookingService)
        {
            _iTicketBookingService = iTicketBookingService;
        }

        public IActionResult GetAllTicketBookings()
        {
            var result = _iTicketBookingService.GetTicketBookingsAsync(e => true);
            return Ok(result);
        }
    }
}