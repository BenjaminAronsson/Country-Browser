using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Labb4
{
    public class CountryService: ICountryService
    {
        private readonly string url;
        private readonly WebClient webClient;
        private ICountryParser parser;


        public CountryService(ICountryParser parser)
        {
            this.parser = parser;
            url = "https://restcountries.eu/rest/v2/all";
            webClient = new WebClient();
        }

        public List<Country> GetCountries()
        {
            var json = webClient.DownloadString(url);

            

            //parsing
            var result = parser.Parse(json);

            return result;
        }
    }
}
