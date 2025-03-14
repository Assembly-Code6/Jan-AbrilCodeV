using BETArandDomain;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BETArandAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private List<WeatherForecast> forecasts = new List<WeatherForecast>();


        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;

            var a = Enumerable.Range(1, 3).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

            forecasts.AddRange(a);
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return forecasts;
        }

        [HttpDelete("{id}")]
        public WeatherForecast Delete(int id)
        {
            WeatherForecast wf = forecasts[id];
            forecasts.RemoveAt(id);
            Console.WriteLine(forecasts.Count);
            return wf;
        }

        [HttpGet("{id}")]
        public WeatherForecast Get(int id)
        {
            Console.WriteLine(forecasts.Count);
            return forecasts[id];
        }


        [HttpPost]
        public WeatherForecast PostWeatherResults([FromBody] WeatherForecast wfBody) //Atencao, NAO PASSAR A DATA
        {
            WeatherForecast wf = new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                TemperatureC = wfBody.TemperatureC,
                Summary = wfBody.Summary
            };

            forecasts.Add(wf);

            Console.WriteLine(forecasts.Count);

            return wf;
        }
    }
}
