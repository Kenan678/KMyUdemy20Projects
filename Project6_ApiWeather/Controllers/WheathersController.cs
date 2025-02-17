﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project6_ApiWeather.Properties.Context;
using Project6_ApiWeather.Properties.Entities;

namespace Project6_ApiWeather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WheathersController : ControllerBase
    {
        WheatherContext context = new WheatherContext();
        [HttpGet]
        public IActionResult WeatherCityList()
        {
            var values = context.Cities.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateWeatherCity(City city)
        {
            context.Cities.Add(city);
            context.SaveChanges();
            return Ok("Seher elave edildi");
        }
        [HttpDelete]
        public IActionResult DeleteWeatherCity(int id)
        {
            var values = context.Cities.Where(x => x.CityId == id).ToList();
            context.Cities.RemoveRange(values);
            context.SaveChanges();
            return Ok("seher silindi");
        }
        [HttpPut]
        public IActionResult UpdateWeatherCity(City city)
        {
            var updatedCity = context.Cities.Find(city.CityId);
            updatedCity.CityName = city.CityName;
            updatedCity.Country = city.Country;
            updatedCity.Detail = city.Detail;
            updatedCity.Temp = city.Temp;
            context.SaveChanges();
            return Ok("seher gucellendi");

        }
        [HttpGet("GetByIdWeatherCity")]
        public IActionResult GetByIdWeatherCity(int id)
        {
            var value = context.Cities.Find(id);
            return Ok(value);
        }
    }
}
