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
    public class BaseController<T> : Controller
    {
        protected Uri _uri;

        public BaseController() {}

        // GET api/values
        [HttpGet]
        public async Task<T> Get()
        {
            MashapeClient client = new MashapeClient();
            var response = await client.GetAsync(_uri);
            
            var success = false;
            if (!response.IsSuccessStatusCode) {
                // create new response message with error state
                throw new InvalidOperationException();
            }

            var result = await ResultAsync(response.Content);

            return result;
        }

        public virtual Task<T> ResultAsync(HttpContent content) {
            return content.ReadAsAsync<T>();
        }
    }
}