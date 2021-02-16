using GreenAfricaAPI.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace GreenAfrica_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBooking _bookRepository;

        public BookingController(IBooking bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult GetAllBookings()
        {
            var allBokings = _bookRepository.GetAll;
            return Ok(allBokings);
        }
    }
}
