using GreenAfricaAPI.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace GreenAfrica_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FleetController : ControllerBase
    {
        private readonly IFleet _fleetRepository;
        public FleetController(IFleet fleetRepo)
        {
            _fleetRepository = fleetRepo;
        }

        [HttpGet]
        public ActionResult Get()
        {

            var fleets = _fleetRepository.GetAll();
            return Ok(fleets);
        }
    }
}
