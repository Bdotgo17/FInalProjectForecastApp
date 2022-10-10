using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ForecastApp.OpenWeatherMapModels;

namespace ForecastApp.ForecastAppModels
{
    public class City
    {
        [Display(Name = "City:")]
        public string Name { get; set; }

        [Display(Name = "Temperature:")]
        public float Temp { get; set; }

        [Display(Name = "Humidity")]
        public int Humidity { get; set; }

        [Display(Name = "Pressure:")]
        public int Pressure { get; set; }

        [Display(Name = "Wind Speed:")]
        public float Wind { get; set; }

        [Display(Name = "Weather Condition:")]
        public string Weather { get; set; }

        private Coord coordinates;

        public Coord GetCoordinates()
        {
            return coordinates;
        }

        internal void SetCoordinates(Coord value)
        {
            coordinates = value;
        }

        private string icon;

        public object GetIcon()
        {
            return icon;
        }

        internal void SetIcon(object value)
        {
            icon = (string)value;
        }

        [Display(Name = "Location:")]
        public Coord Coordinates { get; set; }

        public string Icon { get; set; }
    }
}
