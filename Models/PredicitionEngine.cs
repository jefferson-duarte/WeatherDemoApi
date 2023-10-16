using WeatherDemoApi.Controllers;

namespace WeatherDemoApi.Models
{
    public abstract class PredicitionEngine { }

    public class Magic8Ball : PredicitionEngine
    {
        public Magic8Ball() { }

        public List<string> predicitions()
        {
            return new List<string> { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
        }
    }
}
