using System;
using System.Linq;
using System.Threading.Tasks;


namespace xmasblazor.Data
{
    public class WeatherForecastService
    {
        private SpiDevice tree;

        public Task<WeatherForecast[]> TurnOnAsync(DateTime startDate)
        {
            tree = new SpiDevice();
        }
    }
}
