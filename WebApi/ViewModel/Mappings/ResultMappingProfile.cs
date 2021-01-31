﻿using AutoMapper;
using WebApi.Services.Dto.MercadoLibre.Search;

namespace WebApi.ViewModel.Mappings
{
    public class ResultMappingProfile : Profile
    {
        public ResultMappingProfile()
        {
            CreateMap<Result, ResultViewModel>()
                        .ForMember(x => x.SellerId, x => x.MapFrom(y => y.Seller.Id));
        }
    }
}
