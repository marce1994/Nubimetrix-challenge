using System.Threading.Tasks;
using WebApi.Services.Dto.MercadoLibre.Country;
using WebApi.Services.Dto.MercadoLibre.Search;

namespace WebApi.Services.Contract
{
    public interface IMercadoLibre
    {
        Task<CountryResponse> Countries();
        
        Task<SearchResponse> Search(string query);
    }
}
