using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Services.Contract;
using WebApi.Services.Dto.MercadoLibre.Country;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly IMercadoLibre _mercadoLibre;
        private readonly string[] UnauthorizedCountries = { "BR", "CO" };
        
        public PaisesController(IMercadoLibre mercadoLibre)
        {
            _mercadoLibre = mercadoLibre;
        }

        [HttpGet("{pais}")]
        public async Task<ActionResult<IEnumerable<Country>>> Get(string pais)
        {
            var countriesResponse = await _mercadoLibre.Countries();
            var country = countriesResponse.SingleOrDefault(x => x.Id.Equals(pais, System.StringComparison.InvariantCultureIgnoreCase));

            if (country == null)
                return NotFound();

            if (UnauthorizedCountries.Contains(country.Id))
                return Unauthorized();
            
            return Ok(country);
        }
    }
}
