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
    public class BaseController<T> : Controller
    {
        protected Uri _uri;
        private readonly Keys _keys;

        public BaseController(IOptions<Keys> keys) {
            _keys = keys.Value;
        }

        // GET api/values
        [HttpGet]
        public async Task<T> Get()
        {
            MashapeClient client = new MashapeClient(_keys.XMashUpKey);
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