using AutoMapper;
using HelpApp.Application.DTOs;
using HelpApp.Domain.Entities;

namespace HelpApp.Application.Maps
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile() 
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
