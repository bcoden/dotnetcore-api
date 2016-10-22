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
    public class YearFactController : Controller
    {
        // GET api/values
        [HttpGet]
        public async Task<YearFact> Get(YearFact fact)
        {
            Random r = new Random();
            int year = r.Next(1490, DateTime.Now.Year);
            
            MashapeClient client = new MashapeClient();
            var response = await client.GetAsync(
                new Uri(
                    String.Format("https://numbersapi.p.mashape.com/{0}/year?fragment=true&json=true", year))
            );
            
            var success = false;
            if (!response.IsSuccessStatusCode) {
                // create new response message with error state
                throw new InvalidOperationException();
            }

            var result = await response.Content.ReadAsAsync<YearFact>();

            return result;
        }
    }
}