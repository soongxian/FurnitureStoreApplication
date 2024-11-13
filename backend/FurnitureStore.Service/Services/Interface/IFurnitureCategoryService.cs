using FurnitureStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.BusinessLayer.Services.Interface
{
    public interface IFurnitureCategoryService
    {
        public Task<List<FurnitureCategory>> GetAllFurnitureCategory();
        public Task<FurnitureCategory> AddFurnitureCategory(FurnitureCategory FurnitureCategory);
        public Task<FurnitureCategory> GetFurnitureCategoryByName(string name);
        public Task<FurnitureCategory> EditFurnitureCategory(int id, FurnitureCategory FurnitureCategory);
        public Task<bool> DeleteFurnitureCategory(int id);
    }
}
