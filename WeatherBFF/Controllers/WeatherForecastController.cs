using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.Repositories;

namespace WeatherApp.Controllers
{
    [ApiController]
    [Route("forecast")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherRepo _repo;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherRepo repo)
        {
            _logger = logger;
            _repo = repo;
        }

        [HttpGet("{longitude}&{latitude}&{numDays}/hourly/wind")]
        public ActionResult<IEnumerable<WeatherHourSegment>> GetHourlyPeriod(double longitude, double latitude, int numDays)
        {
            IEnumerable<WeatherHourSegment> forecast = _repo.GetHourlyWindForecast(longitude, latitude, numDays);
            return Ok(forecast);
        }
    }
}
