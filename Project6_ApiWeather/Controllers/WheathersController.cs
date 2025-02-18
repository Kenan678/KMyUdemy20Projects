using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project6_ApiWeather.Properties.Context;
using Project6_ApiWeather.Properties.Entities;

namespace Project6_ApiWeather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WheathersController : ControllerBase
    {
        WheatherContext context=new WheatherContext();
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
    }
}
