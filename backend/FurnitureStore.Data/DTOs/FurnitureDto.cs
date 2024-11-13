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
            public FurnitureBrandGetOnlyBrandNameDto FurnitureBrand { get; set; }
            public FurnitureCategoryGetOnlyCategoryNameDto FurnitureCategory { get; set; }
        }


    }
}
