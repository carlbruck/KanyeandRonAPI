using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KanyeandRonAPI
{
    public class QuoteGenerator
    {
        
            private string kurl = "https://api.kanye.rest";
            private string ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            private HttpClient client;
        public QuoteGenerator(HttpClient newClient)
        {
            client = newClient;
        }
        public string KanyeQuote()
        {


            var kanyeResponse = client.GetStringAsync(kurl).Result;

            return JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            
        }

            public string RonQuote()
        {
            var client = new HttpClient();


            var ronResponse = client.GetStringAsync(ronURL).Result;

            return JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

           

        }

    }
}
