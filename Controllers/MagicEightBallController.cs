using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherDemoApi.Models;

namespace WeatherDemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MagicEightBallController : ControllerBase
    {
        private readonly Magic8Ball magic8Ball = new Magic8Ball();

        public MagicEightBallController() 
        { 
        }

        [HttpGet("List")]

        public List<string> GetList()
        {            
            return magic8Ball.predicitions();
        }

        [HttpGet("prediction")]
        public string GetPredicion()
        {
            Random rnd = new Random();

            List<string> predictions = magic8Ball.predicitions();

            int predictionIndex = rnd.Next(0, predictions.Count);

            return predictions.ToArray()[predictionIndex];
        }

        [HttpGet("prediction/{id}")]

        public string GetSpecificPrediction(int id)
        {
            return magic8Ball.predicitions().ToArray()[id];
        }
    }
}
