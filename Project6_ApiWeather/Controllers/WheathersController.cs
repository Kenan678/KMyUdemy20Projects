using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project6_ApiWeather.Dtos;
using Project6_ApiWeather.Properties.Context;
using Project6_ApiWeather.Properties.Entities;
using System.Linq;

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
        public IActionResult CreateWeatherCity([FromBody] CityCreateDto cityeDto)
        {
            var city = new City
            {
                CityName = cityeDto.CityName,
                Country = cityeDto.Country,
                Temp = cityeDto.Temp,
                Detail = cityeDto.Detail
            };
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
        [HttpGet("GetByAllCityCount")]
        public IActionResult GetByAllCityCount()
        {
            var value = context.Cities.Count();
            return Ok("Toplam  " + value + " seher ");

        }

        [HttpGet("MaxtempCityName")]
        public IActionResult MaxtempCityName()
        {
            var value = context.Cities.OrderByDescending(x => x.Temp).Select(y => y.CityName).FirstOrDefault();
            return Ok(value);
        }

        [HttpGet("MintempCityName")]
        public IActionResult MintempCityName()
        {
            var value = context.Cities.OrderBy(x => x.Temp).Select(y => y.CityName).FirstOrDefault();
            return Ok(value);
        }
    }
}
