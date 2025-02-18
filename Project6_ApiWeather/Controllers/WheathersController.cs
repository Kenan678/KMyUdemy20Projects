using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project6_ApiWeather.Properties.Context;

namespace Project6_ApiWeather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WheathersController : ControllerBase
    {
        WheatherContext context=new WheatherContext();
        [HttpGet]
        public IActionResult wh
    }
}
