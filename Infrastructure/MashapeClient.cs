using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.Extensions.Options;

namespace Api.Infrastructure
{
    public class MashapeClient : HttpClient 
    {
        public MashapeClient(String Mashupkey) {
           
            // defaults
            base.DefaultRequestHeaders.Add("X-Mashape-Key", Mashupkey);
            base.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<HttpResponseMessage> JSONPostAsync(Uri uri, string json) {
            return await base.PostAsync(uri, new StringContent(json, Encoding.UTF8, "application/json"));
        }
    }
}