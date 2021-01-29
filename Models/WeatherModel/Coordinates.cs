using Newtonsoft.Json;

namespace WeatherApi.Models.WeatherModel
{
    public class Coordinates
    {
        [JsonProperty("lon")]
        public decimal Longitude { get; set; }

        [JsonProperty("lat")]
        public decimal Latitude { get; set; }
    }
}
