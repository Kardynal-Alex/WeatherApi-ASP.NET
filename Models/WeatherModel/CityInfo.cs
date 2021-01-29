using Newtonsoft.Json;

namespace WeatherApi.Models.WeatherModel
{
    public class CityInfo
    {
        [JsonProperty("id")]
        public int CItyId { get; set; }

        [JsonProperty("name")]
        public string CityName { get; set; }

        [JsonProperty("coord")]
        public Coordinates Coordinates { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

    }
}
