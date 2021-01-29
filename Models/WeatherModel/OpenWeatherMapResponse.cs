using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherApi.Models.WeatherModel
{
    public class OpenWeatherMapResponse
    {
        [JsonProperty("list")]
        public List<ListInfo> WeatherList { get; set; }

        [JsonProperty("city")]
        public CityInfo City { get; set; }
    }
}
