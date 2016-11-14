using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Api.Infrastructure;
using System.Net.Http;
using Api.Models;
using System.Net.Http.Headers;
using Microsoft.Extensions.Options;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class RecipeController : BaseController<RecipeResponse>
    {
        public RecipeController(IOptions<Keys> config) : base(config) {
            _uri = new Uri("https://community-food2fork.p.mashape.com/search?key=8c50b89145cd55f0a23f6a32efc54242&q=shredded+chicken");
        }

         public override Task<RecipeResponse> ResultAsync(HttpContent content) {
             content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");
            return content.ReadAsAsync<RecipeResponse>();
        }
    }
}