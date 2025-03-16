using Web_API_Versioning.API.Models.Domain;

namespace Web_API_Versioning.API
{
    public class CountriesData
    {
        public static List<Country> Countries = new List<Country>
        {
            new Country { Id = 1, Name = "USA" },
            new Country { Id = 2, Name = "Canada" },
            new Country { Id = 3, Name = "Mexico" }
        };

        public static List<Country> GetCountries()
        {
            return Countries;
        }
    }
}
