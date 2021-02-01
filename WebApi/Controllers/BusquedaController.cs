using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
            dynamic searchResult = await _mercadoLibre.Search(termino);
            searchResult.results = _mapper.Map<IEnumerable<ResultViewModel>>(searchResult.results);
            return Ok(searchResult);
        }
    }
}
