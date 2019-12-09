using System.Collections.Generic;

namespace Labb4
{
    public interface ICountryParser
    {
        List<Country> Parse(string s);
    }
}