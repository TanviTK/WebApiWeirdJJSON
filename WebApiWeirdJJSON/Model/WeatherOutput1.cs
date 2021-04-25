using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWeirdJJSON.Model
{
    public class WeatherOutput1
    {
        public string city { get; set; }
        public string _date { get; set; }
        public WeatherTemperature temperatureInfo { get; set; }
    }
}
