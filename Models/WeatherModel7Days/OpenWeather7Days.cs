using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherApi.Models.WeatherModel7Days
{
    public class OpenWeather7Days
    {
        [JsonProperty("daily")]
        public List<DailyWeather> DailyWeatherInfo { get; set; }
    }
}
