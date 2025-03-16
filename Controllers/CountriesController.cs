using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_API_Versioning.API.Models.DTOs;

namespace Web_API_Versioning.API.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class CountriesController : ControllerBase
    {
        [MapToApiVersion("1.0")]
        [HttpGet]
        public IActionResult GetV1()
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

        [MapToApiVersion("2.0")]
        [HttpGet]
        public IActionResult GetV2()
        {
            var countries = CountriesData.GetCountries();

            var countryDtoList = new List<CountryDtoV2>();


            foreach (var country in countries)
            {
                countryDtoList.Add(new CountryDtoV2
                {
                    Id = country.Id,
                    countryName = country.Name
                });
            }

            return Ok(countryDtoList);

        }
    }
}
