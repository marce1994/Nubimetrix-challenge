using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using WebApi.Services.Contract;
using WebApi.Services.Dto.MercadoLibre.Country;

namespace WebApi.Services.Implementation
{
    public class MercadoLibre : IMercadoLibre
    {
        private static string BaseUrl = "https://api.mercadolibre.com";
        public MercadoLibre()
        {

        }

        public async Task<IEnumerable<Country>> Countries()
        {
            return await $"{BaseUrl}/classified_locations/countries".GetJsonAsync<IEnumerable<Country>>();
        }

        public async Task<dynamic> Search(string query)
        {
            var res = await $"{BaseUrl}/sites/MLA/search?q={query}".GetJsonAsync();
            return res;
        }
    }
}
