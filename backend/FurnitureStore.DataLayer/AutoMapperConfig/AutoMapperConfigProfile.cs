using AutoMapper;
using FurnitureStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FurnitureStore.Data.DTOs.FurnitureBrandDto;
using static FurnitureStore.Data.DTOs.FurnitureCategoryDto;
using static FurnitureStore.Data.DTOs.FurnitureDto;

namespace FurnitureStore.DataLayer.AutoMapperConfig
{
    public class AutoMapperConfigProfile : Profile
    {
        public AutoMapperConfigProfile()
        {
            CreateMap<Furniture, FurnitureGetDto>()
            .ForMember(dest => dest.FurnitureBrand, opt => opt.MapFrom(src => new FurnitureBrandGetOnlyBrandNameDto
            {
                FurnitureBrandName = src.FurnitureBrand.BrandName
            }))
            .ForMember(dest => dest.FurnitureCategory, opt => opt.MapFrom(src => new FurnitureCategoryGetOnlyCategoryNameDto
            {
                FurnitureCategoryName = src.FurnitureCategory.FurnitureCategoryName
            }));

            CreateMap<FurnitureBrand, FurnitureBrandGetOnlyBrandNameDto>()
                .ForMember(dest => dest.FurnitureBrandName, opt => opt.MapFrom(src => src.BrandName));

            CreateMap<FurnitureCategory, FurnitureCategoryGetOnlyCategoryNameDto>()
                .ForMember(dest => dest.FurnitureCategoryName, opt => opt.MapFrom(src => src.FurnitureCategoryName));
        }
    }
}
