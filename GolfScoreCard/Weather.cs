using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static GolfScoreCard.Weather;

namespace GolfScoreCard
{
    internal class Weather
    {

        public class Location
        {
            public string name { get; set; }
            public string region { get; set; }
            public string country { get; set; }
            public double lat { get; set; }
            public double lon { get; set; }
            public string tz_id { get; set; }
            public long localtime_epoch { get; set; }
            public string localtime { get; set; }
        }

        public class Condition
        {
            public string text { get; set; }
            public string icon { get; set; }
            public int code { get; set; }
        }

        public class Current
        {
            public long last_updated_epoch { get; set; }
            public string last_updated { get; set; }
            public double temp_c { get; set; }
            public double temp_f { get; set; }
            public int is_day { get; set; }
            public Condition condition { get; set; }
            public double wind_mph { get; set; }
            public double wind_kph { get; set; }
            public int wind_degree { get; set; }
            public string wind_dir { get; set; }
        }

        public class WeatherApiResponse
        {
            public Location location { get; set; }
            public Current current { get; set; }
        }

        public class WeatherData
        {
            public Location location { get; set; }
            public Current current { get; set; }
        }


        public class WeatherApi
        {
            private const string ApiKey = "024e67f80302411796624118231012";
            private const string ApiBaseUrl = "http://api.weatherapi.com/v1/current.json";

            public async Task<WeatherData> GetWeatherAsync(string q)
            {
                using (var httpClient = new HttpClient())
                {
                    string apiUrl = $"{ApiBaseUrl}?key={ApiKey}&q={q}";
                    var response = await httpClient.GetStringAsync(apiUrl);
                    WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(response);
                    return weatherData;
                }
            }
        }

    }
}
