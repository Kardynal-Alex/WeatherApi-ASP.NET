using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherApi.Models.WeatherModel7Days
{
    public class DailyWeather
    {
        [JsonProperty("temp")]
        public Temperature Temperature { get; set; }

        [JsonProperty("feels_like")]
        public FeelsLikeTemp FeelsLikeTemp { get; set; }

        [JsonProperty("pressure")]
        public int Pressure { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("wind_speed")]
        public decimal WindSpeed { get; set; }

        [JsonProperty("weather")]
        public List<WeatherDescription> WeatherDescriptions { get; set; }
    }
}
