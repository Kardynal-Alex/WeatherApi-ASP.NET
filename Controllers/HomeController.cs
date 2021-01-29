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
namespace WeatherApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public string response;
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
        }
        
        public IActionResult Index()
        {
            OpenWeatherMapResponse json = JsonConvert.DeserializeObject<OpenWeatherMapResponse>(response);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
