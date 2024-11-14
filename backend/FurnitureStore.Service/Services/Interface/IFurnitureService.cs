using FurnitureStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FurnitureStore.Data.DTOs.FurnitureDto;

namespace FurnitureStore.BusinessLayer.Services.Interface
{
    public interface IFurnitureService
    {
        public Task<List<FurnitureGetDto>> GetAllFurnitures();
        public Task<List<FurnitureGetDto>> GetFurnitureByName(string name);
        public Task<FurnitureCreateDto> AddFurniture(FurnitureCreateDto furnitureCreateDto);
        public Task<Furniture> EditFurniture(int id, Furniture furniture);
        public Task<bool> DeleteFurniture(int id);
    }
}
