using System;
using System.IO;
using System.Net;
using System.Net.Http;

namespace Labb4
{
    public class CountryService
    {
        private readonly string url;
        private readonly HttpClient httpClient;


        public CountryService()
        {
             url = "https://restcountries.eu/rest/v2/all";
            httpClient = new HttpClient();
        }

        public void GetCountries()
        {
            var result = httpClient.GetAsync(url).Result;
            Console.WriteLine(result);
        }
    }
}
