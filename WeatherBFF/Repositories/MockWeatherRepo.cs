using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Repositories
{
    public class MockWeatherRepo : IWeatherRepo
    {
        public IEnumerable<WeatherHourSegment> GetHourlyWindForecast(double longitude, double latitude, int numDays)
        {
            return new List<WeatherHourSegment>()
            {
                new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 3, 15, 0, 0),
                    EndTime = new DateTime(2021, 5, 3, 16, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 32
                },new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 3, 16, 0, 0),
                    EndTime = new DateTime(2021, 5, 3, 17, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 32
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 3, 17, 0, 0),
                    EndTime = new DateTime(2021, 5, 3, 18, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 32
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 3, 18, 0, 0),
                    EndTime = new DateTime(2021, 5, 3, 19, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 40
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 3, 19, 0, 0),
                    EndTime = new DateTime(2021, 5, 3, 20, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 40
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 3, 20, 0, 0),
                    EndTime = new DateTime(2021, 5, 3, 21, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 32
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 3, 21, 0, 0),
                    EndTime = new DateTime(2021, 5, 3, 22, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 3, 22, 0, 0),
                    EndTime = new DateTime(2021, 5, 3, 23, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 3, 23, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 00, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 00, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 01, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 32
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 01, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 02, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 32
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 02, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 03, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 40
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 03, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 04, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 40
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 04, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 05, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 40
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 05, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 06, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 40
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 06, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 07, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 40
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 07, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 08, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 40
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 08, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 09, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 40
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 09, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 10, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 40
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 10, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 11, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 40
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 11, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 12, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 48
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 12, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 13, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 40
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 13, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 14, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 40
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 14, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 15, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 40
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 15, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 16, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 40
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 16, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 17, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 40
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 17, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 18, 0, 0),
                    WindSpeedKMH = 24,
                    GustSpeedKMH = 32
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 18, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 19, 0, 0),
                    WindSpeedKMH = 16,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 19, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 20, 0, 0),
                    WindSpeedKMH = 16,
                    GustSpeedKMH = 32
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 20, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 21, 0, 0),
                    WindSpeedKMH = 16,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 21, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 22, 0, 0),
                    WindSpeedKMH = 8,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 22, 0, 0),
                    EndTime = new DateTime(2021, 5, 4, 23, 0, 0),
                    WindSpeedKMH = 8,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 4, 23, 0, 0),
                    EndTime = new DateTime(2021, 5, 5, 00, 0, 0),
                    WindSpeedKMH = 8,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 5, 00, 0, 0),
                    EndTime = new DateTime(2021, 5, 5, 01, 0, 0),
                    WindSpeedKMH = 0,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 5, 01, 0, 0),
                    EndTime = new DateTime(2021, 5, 5, 02, 0, 0),
                    WindSpeedKMH = 0,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 5, 02, 0, 0),
                    EndTime = new DateTime(2021, 5, 5, 03, 0, 0),
                    WindSpeedKMH = 0,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 5, 03, 0, 0),
                    EndTime = new DateTime(2021, 5, 5, 04, 0, 0),
                    WindSpeedKMH = 0,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 5, 04, 0, 0),
                    EndTime = new DateTime(2021, 5, 5, 05, 0, 0),
                    WindSpeedKMH = 0,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 5, 05, 0, 0),
                    EndTime = new DateTime(2021, 5, 5, 06, 0, 0),
                    WindSpeedKMH = 0,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 5, 06, 0, 0),
                    EndTime = new DateTime(2021, 5, 5, 07, 0, 0),
                    WindSpeedKMH = 0,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 5, 07, 0, 0),
                    EndTime = new DateTime(2021, 5, 5, 08, 0, 0),
                    WindSpeedKMH = 0,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 5, 08, 0, 0),
                    EndTime = new DateTime(2021, 5, 5, 09, 0, 0),
                    WindSpeedKMH = 0,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 5, 09, 0, 0),
                    EndTime = new DateTime(2021, 5, 5, 10, 0, 0),
                    WindSpeedKMH = 8,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 5, 10, 0, 0),
                    EndTime = new DateTime(2021, 5, 5, 11, 0, 0),
                    WindSpeedKMH = 8,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 5, 11, 0, 0),
                    EndTime = new DateTime(2021, 5, 5, 12, 0, 0),
                    WindSpeedKMH = 8,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 5, 12, 0, 0),
                    EndTime = new DateTime(2021, 5, 5, 13, 0, 0),
                    WindSpeedKMH = 8,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 5, 13, 0, 0),
                    EndTime = new DateTime(2021, 5, 5, 14, 0, 0),
                    WindSpeedKMH = 8,
                    GustSpeedKMH = 0
                },            new WeatherHourSegment()
                {
                    StartTime = new DateTime(2021, 5, 5, 14, 0, 0),
                    EndTime = new DateTime(2021, 5, 5, 15, 0, 0),
                    WindSpeedKMH = 8,
                    GustSpeedKMH = 0
                }
            };
        }
    }
}
