using System;

namespace WeatherApp.Models
{
    public class WeatherHourSegment
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int WindSpeedKMH { get; set; }
        public int WindSpeedMPH => (int)Math.Round(WindSpeedKMH * 0.621371);
        public int GustSpeedKMH { get; set; }
        public int GustSpeedMPH => (int)Math.Round(GustSpeedKMH * 0.621371);
        //{
        //    get
        //    {
        //        if (GustSpeedMPH != null) return (int)Math.Round((double)GustSpeedKMH * 0.621371);
        //        else return null;
        //    }
        //}

    }
}
