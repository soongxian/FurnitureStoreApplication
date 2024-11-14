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

        public async Task<FurnitureCreateDto> AddFurniture(FurnitureCreateDto furniture)
        {

            var furnitureMapping = new Furniture
            {
                Name = furniture.Name,
                Quantity = furniture.Quantity,
                Price = furniture.Price,
                FurnitureBrandId = furniture.FurnitureBrandId,
                FurnitureCategoryId = furniture.FurnitureCategoryId
            };

            _dbContext.Furnitures.Add(furnitureMapping);
            await _dbContext.SaveChangesAsync();

            return furniture;
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
                    FurnitureBrandName = f.FurnitureBrand.FurnitureBrandName,
                    FurnitureCategoryName = f.FurnitureCategory.FurnitureCategoryName                
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
                    FurnitureBrandName = f.FurnitureBrand.FurnitureBrandName,
                    FurnitureCategoryName = f.FurnitureCategory.FurnitureCategoryName
                }).ToListAsync();

            return furnitures;
        }
    }
}
