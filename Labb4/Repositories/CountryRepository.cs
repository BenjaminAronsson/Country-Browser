using System;
using System.Collections.Generic;

namespace Labb4
{
    public class CountryRepository : ICountryRepository
    {
        
        public List<Country> Countries { get; set; }

        public CountryRepository()
        {
            Countries = new List<Country>
            {
                new Country
                {
                    Currency = "SEK",
                    Description = "IKEA, köttbullar å sånt",
                    Name = "sweden",
                    Population = 9000000
                },

                new Country
                {
                    Currency = "NKR",
                    Description = "Olja har vi mycket av",
                    Name = "norway",
                    Population = 13000000
                },

                new Country
                {
                    Currency = "EUR",
                    Description = "Denmark is a Scandinavian country comprising the Jutland Peninsula and numerous islands. It's linked to nearby Sweden via the Öresund bridge. Copenhagen, its capital, is home to royal palaces and colorful Nyhavn harbor, plus the Tivoli amusement park and the iconic “Little Mermaid” statue. Odense is writer Hans Christian Andersen’s hometown, with a medieval core of cobbled streets and half-timbered houses.",
                    Name = "denmark",
                    Population = 5603000
                }
            };


        }

        
    }
}
