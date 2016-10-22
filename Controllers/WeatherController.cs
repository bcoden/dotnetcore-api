using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Api.Infrastructure;
using System.Net.Http;
using Api.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class WeatherController : Controller
    {
        // GET api/values
        [HttpGet]
        public async Task<Weather> Get()
        {
            MashapeClient client = new MashapeClient();
            var response = await client.GetAsync(new Uri("https://simple-weather.p.mashape.com/weather?lat=48.9465&lng=-122.4521"));
            
            var success = false;
            if (!response.IsSuccessStatusCode) {
                // create new response message with error state
            }

            var result = await response.Content.ReadAsStringAsync();
            var results = result.Split(new char[] { ',' }, 2);

            var Temp = new Temperature() {
                unit = Int16.Parse(results[0].Substring(0, results[0].Length-1))
            };

            var data = new Weather {
                Temperature = Temp.toFahrenheit().toString(),
                Current = results[1]
            };

            return data;
        }
    }
}
