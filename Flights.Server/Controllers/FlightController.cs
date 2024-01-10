using Flights.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flights.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightController : ControllerBase
    {
        private readonly ILogger<FlightController> _logger;

        public FlightController(ILogger<FlightController> logger)
        {
            _logger = logger;
        }

        Random random = new Random();

        [HttpGet]
        public IEnumerable<FlightRm> Search()
        {
            return new FlightRm[]
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
        }
    }
}
