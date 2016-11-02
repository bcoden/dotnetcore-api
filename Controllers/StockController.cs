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
    public class StockController : BaseController<Stock>
    {
        public StockController() {
            // todo set up stock and dates
            _uri = new Uri("https://stockvider.p.mashape.com/NASDAQ/AAPL/EOD?end_date=2016-10-20&start_date=2016-10-21");
        }

         public override Task<Stock> ResultAsync(HttpContent content) {
            return content.ReadAsAsync<Stock>();
        }
    }
}