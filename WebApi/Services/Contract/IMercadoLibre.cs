using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Services.Dto.MercadoLibre.Country;

namespace WebApi.Services.Contract
{
    public interface IMercadoLibre
    {
        Task<IEnumerable<Country>> Countries();
        
        Task<dynamic> Search(string query);
    }
}
