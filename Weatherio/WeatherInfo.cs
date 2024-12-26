using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weatherio
{
    internal class WeatherInfo
    {
        public class Location
        {
            public string Name { get; set; }
            public string Region { get; set; }
            public string Country { get; set; }
            public double Lat { get; set; }
            public double Lon { get; set; }
            public string Tz_id { get; set; }
            public long Localtime_epoch { get; set; }
            public string Localtime { get; set; }
        }

        public class Condition
        {
            public string Text { get; set; }
            public string Icon { get; set; }
            public int Code { get; set; }
        }

        public class AirQuality
        {
            public double Co { get; set; }
            public double No2 { get; set; }
            public double O3 { get; set; }
            public double So2 { get; set; }
            public double Pm25 { get; set; }
            public double Pm10 { get; set; }
            public int UsEpaIndex { get; set; }
            public int GbDefraIndex { get; set; }
        }

        public class Current
        {
            public long LastUpdatedEpoch { get; set; }
            public string LastUpdated { get; set; }
            public float TempC { get; set; }
            public double TempF { get; set; }
            public int IsDay { get; set; }
            public double WindMph { get; set; }
            public float WindKph { get; set; }
            public int WindDegree { get; set; }
            public string WindDir { get; set; }
            public float PressureMb { get; set; }
            public double PressureIn { get; set; }
            public double PrecipMm { get; set; }
            public double PrecipIn { get; set; }
            public int Humidity { get; set; }
            public int Cloud { get; set; }
            public double FeelslikeC { get; set; }
            public double FeelslikeF { get; set; }
            public double VisKm { get; set; }
            public double VisMiles { get; set; }
            public float Uv { get; set; }
            public double GustMph { get; set; }
            public double GustKph { get; set; }
            public Condition Condition { get; set; }
            public AirQuality AirQuality { get; set; }
        }

        public class Root
        {
            public Location Location { get; set; }
            public Current Current { get; set; }

        }
    }
}
