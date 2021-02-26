using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeandRonAPI
{
    class Program
    {
        private static string kanyeURL;

        static void Main(string[] args)
        {
            var client = new HttpClient();

            var quoteGenerator = new QuoteGenerator(client);


            var kanyeQuote = quoteGenerator.KanyeQuote();

            var ronQuote = quoteGenerator.RonQuote();


            //var client = new HttpClient();



            //var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            //var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            //Console.WriteLine($"{kanyeQuote}");

            Console.WriteLine($"_______________________________");
            Console.WriteLine($"Kanye: '{kanyeQuote}'");
            Console.WriteLine($"_______________________________");





            Console.WriteLine($"_______________________________");
            Console.WriteLine($"Ron: '{ronQuote}'");
            Console.WriteLine($"_______________________________");
        }
    }
}
