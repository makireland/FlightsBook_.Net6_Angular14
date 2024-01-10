using Flights.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flights.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightController : ControllerBase
    {
        private readonly ILogger<FlightController> _logger;
        static Random random = new Random();

        public FlightController(ILogger<FlightController> logger)
        {
            _logger = logger;
        }

        static private FlightRm[] flights = new FlightRm[]
        {
            new (Guid.NewGuid(),
            "America Airline",
            random.Next(90,5000).ToString(),
            new TimePlaceRm("Los Angeles", DateTime.Now.AddHours(random.Next(1, 3))),
            new TimePlaceRm("Istanbul", DateTime.Now.AddHours(random.Next(4, 13))),
            random.Next(1, 853)),

            new (Guid.NewGuid(),
            "Airlingus",
            random.Next(90,5000).ToString(),
            new TimePlaceRm("Dublin", DateTime.Now.AddHours(random.Next(1, 13))),
            new TimePlaceRm("Spain", DateTime.Now.AddHours(random.Next(4, 15))),
            random.Next(1, 853)),

            new (Guid.NewGuid(),
            "Ryanair",
            random.Next(90,5000).ToString(),
            new TimePlaceRm("London", DateTime.Now.AddHours(random.Next(1, 15))),
            new TimePlaceRm("Portugal", DateTime.Now.AddHours(random.Next(4, 18))),
            random.Next(1, 853)),

            new (Guid.NewGuid(),
            "Latam",
            random.Next(90,5000).ToString(),
            new TimePlaceRm("Sao Paulo", DateTime.Now.AddHours(random.Next(1, 12))),
            new TimePlaceRm("Goiania", DateTime.Now.AddHours(random.Next(2, 16))),
            random.Next(1, 853)),
        };

        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(IEnumerable<FlightRm>), StatusCodes.Status200OK)]
        [HttpGet]
        public IEnumerable<FlightRm> Search()
        {
            return flights;
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(FlightRm), StatusCodes.Status200OK)]
        [HttpGet("{id}")]
        public ActionResult<FlightRm> Find(Guid id)
        {
            var flight = flights.SingleOrDefault(f => f.Id == id);
            
            if (flight == null)
                return NotFound();

            return Ok(flight);
        }
    }
}
