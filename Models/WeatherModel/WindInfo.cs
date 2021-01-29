using Newtonsoft.Json;

namespace WeatherApi.Models.WeatherModel
{
    public class WindInfo
    {
        [JsonProperty("speed")]
        public decimal Speed { get; set; }
    }
}
