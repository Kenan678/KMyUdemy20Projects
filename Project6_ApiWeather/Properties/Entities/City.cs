﻿using System.Text.Json.Serialization;

namespace Project6_ApiWeather.Properties.Entities
{
    public class City
    {
       
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string Country { get; set; }
        public decimal Temp { get; set; }
        public string Detail { get; set; }

    }
}
