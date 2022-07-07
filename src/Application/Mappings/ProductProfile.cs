using Application.DTO_s.ProductDtos;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductListDto>().ReverseMap()
                .ForMember(dest => dest.Category.Name, opt => opt.MapFrom(src => src.Category))
                .ForMember(dest => dest.Brand.Name, opt => opt.MapFrom(src => src.Brand))
                .ForMember(dest => dest.Color.Name, opt => opt.MapFrom(src => src.Color));

        }
    }
}
