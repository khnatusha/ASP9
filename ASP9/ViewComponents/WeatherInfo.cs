using ASP9.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json;

namespace ASP9.ViewComponents
{
    public class WeatherInfo : ViewComponent
    {
        public IViewComponentResult Invoke(string city)
        {
            string json;
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric" +
                $"&appid=b122aeba1feaa5a3fc0f834a0e234434";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                json = reader.ReadToEnd();
            }
            ForecastData weatherData = JsonConvert.DeserializeObject<ForecastData>(json);
            return View(weatherData);
        }
    }
}

