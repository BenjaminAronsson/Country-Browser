using Ninject.Modules;
using Ninject;

namespace Labb4 {
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ICountryService>().To<CountryService>();
            Bind<ICountryParser>().To<CountryJsonParser>();
            Bind<ICountryRepository>().To<CountryRepository>();
        }
    }
}