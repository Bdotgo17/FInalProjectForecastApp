
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForecastApp.Config;
using ForecastApp.OpenWeatherMapModels;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json.Linq;
using Microsoft.VisualBasic;
using System.Text.Json.Serialization;
using Constants = ForecastApp.Config.Constants;

namespace ForecastApp.Repositories
{
    public class ForecastRepository : IForecastRepository
    {
        

        WeatherResponse IForecastRepository.GetForecast(string city)
        {
            string IDOWeather = Constants.OPEN_WEATHER_APPID;
            // Connection String
            var client = new RestClient($"http://api.openweathermap.org/data/2.5");
            var request = new RestRequest($"/weather?q={city}&units=metric&APPID={IDOWeather}", Method.Get);
            RestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                // Deserialize the string content into JToken object
                var content = JsonConvert.DeserializeObject<WeatherResponse>(response.Content);

                // Deserialize the JToken object into our WeatherResponse Class
                //return content.ToObject<WeatherResponse>();
                return content;
            }

            return null;
        }
    }
}

