using AutoMapper;
using WebApi.Services.Dto.MercadoLibre.Search;

namespace WebApi.ViewModel.Mappings
{
    public class SearchResponseMappingProfile:Profile
    {
        public SearchResponseMappingProfile()
        {
            CreateMap<SearchResponse, SearchResponseViewModel>();
        }        
    }
}
