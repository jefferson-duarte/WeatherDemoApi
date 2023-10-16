using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace WeatherDemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet(Name = "GetSuperHeroes")]

        public List<string> Get()
        {
            List<string> strings = new List<string>();
            strings.Add("Bruce Wayne");
            strings.Add("Peter Parke");
            return strings;
        }
    }
}
