using ASP9.Models;
using Microsoft.AspNetCore.Mvc;


namespace ASP9.Controllers
{
    public class ForecastController : Controller
    {
        [HttpGet]
        public IActionResult Weather()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Weather(string city)
        {
            return View("WeatherInfo", city);
        }
        [HttpGet]
        public IActionResult WeatherInfo(string city)
        {
            return View(city);
        }
    }
}

