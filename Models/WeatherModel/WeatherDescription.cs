using Newtonsoft.Json;

namespace WeatherApi.Models.WeatherModel
{
    public class WeatherDescription
    {
        [JsonProperty("main")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string FullDescription { get; set; }
    }
}
