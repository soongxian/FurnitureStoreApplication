using FurnitureStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.Data.DatabaseContext
{
    public class FurnitureStoreDbContext : DbContext
    {
        public FurnitureStoreDbContext(DbContextOptions options) : base(options) {}

        public DbSet<Furniture> Furnitures { get; set; }
        public DbSet<FurnitureBrand> FurnitureBrands { get; set; }
        public DbSet<FurnitureCategory> FurnitureCategory { get; set; }

    }
}
