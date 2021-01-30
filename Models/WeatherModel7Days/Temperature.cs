using Newtonsoft.Json;

namespace WeatherApi.Models.WeatherModel7Days
{
    public class Temperature
    {
        [JsonProperty("morn")]
        public decimal Morning { get; set; }

        [JsonProperty("day")]
        public decimal Afternoon { get; set; }

        [JsonProperty("eve")]
        public decimal Evening { get; set; }

        [JsonProperty("night")]
        public decimal Nigth { get; set; }

        [JsonProperty("min")]
        public decimal MinTemp { get; set; }

        [JsonProperty("max")]
        public decimal MaxTemp { get; set; }
    }
}
