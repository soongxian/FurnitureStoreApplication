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
            CreateMap<Furniture, FurnitureGetDto>();
            CreateMap<FurnitureCreateDto, Furniture>();
        }
    }
}
