using WeatherApi.Models.WeatherModel7Days;
using WeatherApi.Models.WeatherModel;

namespace WeatherApi.Models
{
    public class GeneralWeatherModel
    {
        public OpenWeatherMapResponse OpenWeatherMapResponse { get; set; }

        public OpenWeather7Days OpenWeather7Days { get; set; }
    }
}
