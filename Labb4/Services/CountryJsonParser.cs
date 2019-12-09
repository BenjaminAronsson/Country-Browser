using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Labb4
{
    public class CountryJsonParser : ICountryParser
    {
        public List<Country> Parse(String json)
        {
            return JsonConvert.DeserializeObject<List<Country>>(json);
        }
    }
}
