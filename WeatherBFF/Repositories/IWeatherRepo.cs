using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Repositories
{
    public interface IWeatherRepo
    {
        public IEnumerable<WeatherHourSegment> GetHourlyWindForecast(double longitude, double latitude, int numDays);
    }
}
