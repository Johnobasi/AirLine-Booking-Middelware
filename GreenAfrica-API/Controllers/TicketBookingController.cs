using GreenAfrica.DataAccess.Models;
using GreenAfrica_API.Dtos;
using GreenAfricaAPI.Business.Abstract;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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

        [HttpGet]
        public IActionResult GetAllTicketBookings()
        {
            var result = _iTicketBookingService.GetTicketBookingsAsync(e => true);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddTicketBookings(TicketBookingDto request)
        {
            await _iTicketBookingService.AddTicketBookingAsync
                 (
                      new TicketBooking
                      {
                          ArrivalDate = request.ArrivalDate,
                          Departure = request.Departure,
                          DepartureDate = request.DepartureDate,
                          Destination = request.Destination,
                          FirstName = request.FirstName,
                          EmailAddress = request.EmailAddress,
                          Dob = request.Dob,
                          EmergencyPhoneNumber = request.EmergencyPhoneNumber,
                          Gender = request.Gender,
                          LastName = request.LastName,
                          Passport = request.Passport,
                          PhoneNumber = request.PhoneNumber,
                          TicketStatus = request.TicketStatus,
                          IsInternational = request.IsInternational
                      }
                 );

            return Created(this.Request.GetDisplayUrl(), null);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetTicketBookings(int Id)
        {
            var result = await _iTicketBookingService.GetTicketBookingAsyncById(Id);
            return Ok(result);
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateTicketBookings([FromRoute] int Id, [FromBody] TicketBookingDto request)
        {
        }
    }
}