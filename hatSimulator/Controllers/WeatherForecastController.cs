using Microsoft.AspNetCore.Mvc;
using hatSimulator.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace hatSimulator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            
                // using (var context = new HatContext())
                // {   
                //     Console.WriteLine($"Database path: {context.DbPath}.");
                //     var number = new Phone(Phone="12345678");
                //     var hat = new Hat{ number };
                //     context.Add(hat);
                //     context.SaveChanges();
                //     Console.WriteLine("made it after save changes");
                //     var savedHat = context.Hats.
                //     OrderBy( hat => b.HatId)
                //     .First();
                //     Console.WriteLine("got hat: " + savedHat.HatID + " <-- that was id");
                // }

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}