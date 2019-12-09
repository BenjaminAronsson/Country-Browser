using System;
using System.Collections.Generic;

namespace Labb4
{
    public class CountryRepository : ICountryRepository
    {
        private List<Country> Countries { get; set; }
        public List<Country> GetCountries() => Countries;
        private ICountryService service;

        public CountryRepository(ICountryService service)
        {
            this.service = service;
            Countries = service.GetCountries();
        }
    }
}
