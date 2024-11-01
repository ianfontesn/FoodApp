using AutoMapper;
using FoodApp.Menu.Models;

namespace FoodApp.Menu.DTOs.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryDTO>()
            .ReverseMap();

        CreateMap<Product , ProductDTO>()
            .ReverseMap();
    }
}
