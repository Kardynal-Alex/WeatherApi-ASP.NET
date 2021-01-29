using Newtonsoft.Json;

namespace WeatherApi.Models.WeatherModel
{
    public class TemperatureInfo
    {
        [JsonProperty("temp")]
        public decimal Temperature { get; set; }

        [JsonProperty("feels_like")]
        public decimal FeelsLikeTemp { get; set; }

        [JsonProperty("temp_min")]
        public decimal MinTemp { get; set; }

        [JsonProperty("temp_max")]
        public decimal MaxTemp { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }
    }
}
