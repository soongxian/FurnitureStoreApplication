using FurnitureStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FurnitureStore.Data.DTOs.FurnitureBrandDto;
using static FurnitureStore.Data.DTOs.FurnitureCategoryDto;

namespace FurnitureStore.Data.DTOs
{
    public class FurnitureDto
    {
        public class FurnitureGetDto
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public double Quantity { get; set; }
            public string FurnitureBrandName { get; set; }
            public string FurnitureCategoryName { get; set; }
        }

        public class FurnitureCreateDto
        {
            public string Name { get; set; }
            public int FurnitureBrandId { get; set; }
            public int FurnitureCategoryId { get; set; }
            public double Price { get; set; }
            public double Quantity { get; set; }
        }

    }
}
