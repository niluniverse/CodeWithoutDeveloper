using Microsoft.AspNetCore.Mvc;
using POCWebApplication.Models;

namespace POCWebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        private static readonly List<Country> Countries =
        [
            new Country { Name = "United States", Code = "US", Capital = "Washington D.C.", CountryCode = "+1" },
            new Country { Name = "United Kingdom", Code = "GB", Capital = "London", CountryCode = "+44" },
            new Country { Name = "Canada", Code = "CA", Capital = "Ottawa", CountryCode = "+1" },
            new Country { Name = "Australia", Code = "AU", Capital = "Canberra", CountryCode = "+61" },
            new Country { Name = "Germany", Code = "DE", Capital = "Berlin", CountryCode = "+49" },
            new Country { Name = "France", Code = "FR", Capital = "Paris", CountryCode = "+33" },
            new Country { Name = "Japan", Code = "JP", Capital = "Tokyo", CountryCode = "+81" },
            new Country { Name = "India", Code = "IN", Capital = "New Delhi", CountryCode = "+91" },
            new Country { Name = "Brazil", Code = "BR", Capital = "Brasília", CountryCode = "+55" },
            new Country { Name = "Mexico", Code = "MX", Capital = "Mexico City", CountryCode = "+52" }
        ];

        [HttpGet(Name = "GetCountries")]
        public ActionResult<IEnumerable<Country>> Get()
        {
            return Ok(Countries);
        }
    }
}