using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WeatherApi.Models.WeatherModel
{
    public class ListInfo
    {
        [JsonProperty("main")]
        public TemperatureInfo TemperatureInfo { get; set; }
        
        [JsonProperty("weather")]
        public List<WeatherDescription> WeatherDescription { get; set; }
        
        [JsonProperty("wind")]
        public WindInfo WindInfo { get; set; }

        [JsonProperty("dt_txt")]
        public DateTime DateTime { get; set; }
    }
}
