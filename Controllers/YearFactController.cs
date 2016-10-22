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
    public class YearFactController : BaseController<YearFact>
    {
        public YearFactController() {
            Random r = new Random();
            int year = r.Next(1490, DateTime.Now.Year);
            _uri = new Uri(
                String.Format("https://numbersapi.p.mashape.com/{0}/year?fragment=true&json=true", year)
            );
        }

        public override Task<YearFact> ResultAsync(HttpContent content) {
            return content.ReadAsAsync<YearFact>();
        }
    }
}