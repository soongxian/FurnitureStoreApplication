using FurnitureStore.BusinessLayer.Services.Interface;
using FurnitureStore.Data.Models;
using FurnitureStore.DataLayer.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FurnitureStore.Data.DTOs.FurnitureDto;

namespace FurnitureStore.BusinessLayer.Services
{
    public class FurnitureService : IFurnitureService
    {
        private readonly IFurnitureRepository _furnitureRepository;

        public FurnitureService(IFurnitureRepository furnitureRepository)
        {
            _furnitureRepository = furnitureRepository;
        }

        public Task<Furniture> AddFurniture(Furniture furniture)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteFurniture(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Furniture> EditFurniture(int id, Furniture furniture)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FurnitureGetDto>> GetAllFurnitures()
        {
            return await _furnitureRepository.GetAllFurnitures();
        }

        public async Task<List<FurnitureGetDto>> GetFurnitureByName(string name)
        {
            return await _furnitureRepository.GetFurnitureByName(name);
        }
    }
}
