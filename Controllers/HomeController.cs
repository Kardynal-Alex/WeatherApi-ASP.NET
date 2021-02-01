using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WeatherApi.Models;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using WeatherApi.Models.WeatherModel;
using WeatherApi.Models.Charts;
using WeatherApi.Models.WeatherModel7Days;
namespace WeatherApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public string response;
        public string sevenDaysResponse;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            string url = "https://api.openweathermap.org/data/2.5/forecast?q=Kyiv&units=metric&appid=43e0253ee3a7eab5c16608b1217424dd";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream())) 
            {
                response = streamReader.ReadToEnd();
            }
            string sevenDaysUrl = "https://api.openweathermap.org/data/2.5/onecall?lat=50.4333&lon=30.5167&exclude=current,minutely,hourly,alerts&units=metric&appid=43e0253ee3a7eab5c16608b1217424dd";
            httpWebRequest = (HttpWebRequest)WebRequest.Create(sevenDaysUrl);
            httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                sevenDaysResponse = streamReader.ReadToEnd();
            }
        }
        public IActionResult Index()
        {
            OpenWeatherMapResponse WeatherInfo = JsonConvert.DeserializeObject<OpenWeatherMapResponse>(response);
            List<DataPoint> dataPoints = new List<DataPoint>();
            List<DataPoint1> dataPoints1 = new List<DataPoint1>();
            foreach (var item in WeatherInfo.WeatherList.Skip(0).Take(8))
            {
                dataPoints.Add(new DataPoint(item.DateTime.ToString("HH:mm"), item.TemperatureInfo.Temperature));
                dataPoints1.Add(new DataPoint1(item.DateTime.ToString("HH:mm"), item.TemperatureInfo.Humidity));
            }
            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);
            ViewBag.DataPoints1 = JsonConvert.SerializeObject(dataPoints1);
            OpenWeather7Days WeatherInfo7Days = JsonConvert.DeserializeObject<OpenWeather7Days>(sevenDaysResponse);

            return View(new GeneralWeatherModel
            {
                OpenWeatherMapResponse = WeatherInfo,
                OpenWeather7Days = WeatherInfo7Days
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
