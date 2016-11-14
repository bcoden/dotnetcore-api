using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Api.Infrastructure;
using System.Net.Http;
using Api.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class WeatherController : BaseController<Weather>
    {
        public WeatherController(IOptions<Keys> config) : base(config) {
            _uri = new Uri("https://simple-weather.p.mashape.com/weather?lat=48.9465&lng=-122.4521");
        }

        public override Task<Weather> ResultAsync(HttpContent content) {
            var result = content.ReadAsStringAsync().Result;
            var results = result.Split(new char[] { ',' }, 2);

            var Temp = new Temperature() {
                unit = Int16.Parse(results[0].Substring(0, results[0].Length-1))
            };

            var data = new Weather {
                Temperature = Temp.toFahrenheit().toString(),
                Current = results[1]
            };

            return Task.Run( () => { 
                return data;
            });
        }
    }
}
