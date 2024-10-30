using AutoMapper;
using FoodApp.Menu.Models;

namespace FoodApp.Menu.DTOs.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryDTO>()
            .ForMember(m => m.ReferenceCode, opt => opt.MapFrom(src => src.ReferenceCode!.ToLower()))
            .ReverseMap();

        CreateMap<Product , ProductDTO>()
            .ForMember(m => m.ReferenceCode, opt => opt.MapFrom(src => src.ReferenceCode!.ToLower()))
            .ReverseMap();
    }
}
