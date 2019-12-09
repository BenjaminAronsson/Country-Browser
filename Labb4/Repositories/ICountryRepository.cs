using System.Collections.Generic;

namespace Labb4
{
    public interface ICountryRepository
    {

        List<Country> GetCountries();
    }
}