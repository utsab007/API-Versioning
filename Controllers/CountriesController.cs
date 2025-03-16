using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_API_Versioning.API.Models.DTOs;

namespace Web_API_Versioning.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var countries = CountriesData.GetCountries();

            var countryDtoList = new List<CountryDtoV1>();


            foreach (var country in countries)
            {
                countryDtoList.Add(new CountryDtoV1
                {
                    Id = country.Id,
                    Name = country.Name
                });
            }

            return Ok(countryDtoList);

        }
    }
}
