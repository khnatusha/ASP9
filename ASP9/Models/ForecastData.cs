namespace ASP9.Models
{
    public class ForecastData
    {
        public List<Weather> Weather { get; set; }
        public WeatherForecast Main { get; set; }
        public Wind Wind { get; set; }
        public string Name { get; set; }
    }
}

