using FurnitureStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.DataLayer.Repositories.Interface
{
    public interface IFurnitureBrandRepository
    {
        public Task<List<FurnitureBrand>> GetAllFurnitureBrand();
        public Task<FurnitureBrand> AddFurnitureBrand(FurnitureBrand FurnitureBrand);
        public Task<FurnitureBrand> GetFurnitureBrandByName(string name);
        public Task<FurnitureBrand> EditFurnitureBrand(int id, FurnitureBrand FurnitureBrand);
        public Task<bool> DeleteFurnitureBrand(int id);
    }
}
