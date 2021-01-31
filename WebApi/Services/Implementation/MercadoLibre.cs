using System.Threading.Tasks;
using Flurl.Http;
using WebApi.Services.Contract;
using WebApi.Services.Dto.MercadoLibre.Country;
using WebApi.Services.Dto.MercadoLibre.Search;

namespace WebApi.Services.Implementation
{
    public class MercadoLibre : IMercadoLibre
    {
        private static string BaseUrl = "https://api.mercadolibre.com";
        public MercadoLibre()
        {

        }

        public async Task<CountryResponse> Countries()
        {
            return await $"{BaseUrl}/classified_locations/countries".GetJsonAsync<CountryResponse>();
        }

        public async Task<SearchResponse> Search(string query)
        {
            return await $"{BaseUrl}/sites/MLA/search?q={query}".GetJsonAsync<SearchResponse>();
        }
    }
}
