using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApi.Services.Contract;
using WebApi.ViewModel;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusquedaController : ControllerBase
    {
        private readonly IMercadoLibre _mercadoLibre;
        private readonly IMapper _mapper;

        public BusquedaController(IMercadoLibre mercadoLibre, IMapper mapper)
        {
            _mercadoLibre = mercadoLibre;
            _mapper = mapper;
        }

        [HttpGet("{termino}")]
        public async Task<IActionResult> Get(string termino)
        {
            var searchResult = await _mercadoLibre.Search(termino);
            return Ok(_mapper.Map<SearchResponseViewModel>(searchResult));
        }
    }
}
