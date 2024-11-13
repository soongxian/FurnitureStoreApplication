using FurnitureStore.Data.DatabaseContext;
using FurnitureStore.Data.Models;
using FurnitureStore.DataLayer.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FurnitureStore.Data.DTOs.FurnitureBrandDto;
using static FurnitureStore.Data.DTOs.FurnitureCategoryDto;
using static FurnitureStore.Data.DTOs.FurnitureDto;

namespace FurnitureStore.DataLayer.Repositories
{
    public class FurnitureRepository : IFurnitureRepository
    {
        private readonly FurnitureStoreDbContext _dbContext;

        public FurnitureRepository(FurnitureStoreDbContext dbContext)
        {
            _dbContext = dbContext;
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
            var furnitures = await _dbContext.Furnitures
                .Include(f => f.FurnitureBrand)
                .Include(f => f.FurnitureCategory)
                .OrderBy(f => f.Name)
                .Select(f => new FurnitureGetDto()
                {
                    Id = f.Id,
                    Name = f.Name,
                    Quantity = f.Quantity,
                    Price = f.Price,
                    FurnitureBrand = new FurnitureBrandGetOnlyBrandNameDto
                    {
                        FurnitureBrandName = f.FurnitureBrand.BrandName
                    },
                    FurnitureCategory = new FurnitureCategoryGetOnlyCategoryNameDto
                    {
                        FurnitureCategoryName = f.FurnitureCategory.FurnitureCategoryName
                    }
                }).ToListAsync();

            return furnitures;
        }

        public async Task<List<FurnitureGetDto>> GetFurnitureByName(string FurnitureName)
        {
            var furnitures = await _dbContext.Furnitures
                .Include(f => f.FurnitureBrand)
                .Include(f => f.FurnitureCategory)
                .Where(f => EF.Functions.Like(f.Name, $"%{FurnitureName}%"))
                .OrderBy(f => f.Name)
                .Select(f => new FurnitureGetDto()
                {
                    Id = f.Id,
                    Name = f.Name,
                    Quantity = f.Quantity,
                    Price = f.Price,
                    FurnitureBrand = new FurnitureBrandGetOnlyBrandNameDto
                    {
                        FurnitureBrandName = f.FurnitureBrand.BrandName
                    },
                    FurnitureCategory = new FurnitureCategoryGetOnlyCategoryNameDto
                    {
                        FurnitureCategoryName = f.FurnitureCategory.FurnitureCategoryName
                    }
                }).ToListAsync();

            return furnitures;
        }
    }
}
