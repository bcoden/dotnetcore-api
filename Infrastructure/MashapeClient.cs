using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

namespace Api.Infrastructure
{
    public class MashapeClient : HttpClient 
    {
        private HttpClient _client;

        public MashapeClient() {
           
            // defaults
            base.DefaultRequestHeaders.Add("X-Mashape-Key","wblTu784g7msh9npewlZO3loVOEcp1X0AkDjsn3jUqtukA0T2Q");
            base.DefaultRequestHeaders.Add("Accept","text/plain");
        }

        public async Task<HttpResponseMessage> JSONPostAsync(Uri uri, string json) {
            return await base.PostAsync(uri, new StringContent(json, Encoding.UTF8, "application/json"));
        }
    }
}