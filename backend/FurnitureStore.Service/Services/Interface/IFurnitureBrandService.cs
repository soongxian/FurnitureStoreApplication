using FurnitureStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.BusinessLayer.Services.Interface
{
    public interface IFurnitureBrandService
    {
        public Task<List<FurnitureBrand>> GetAllFurnitureBrand();
        public Task<FurnitureBrand> AddFurnitureBrand(FurnitureBrand FurnitureBrand);
        public Task<FurnitureBrand> GetFurnitureBrandByName(string name);
        public Task<FurnitureBrand> EditFurnitureBrand(int id, FurnitureBrand FurnitureBrand);
        public Task<bool> DeleteFurnitureBrand(int id);
    }
}
