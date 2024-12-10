using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.Data.Models
{
    public class Furniture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public int FurnitureBrandId { get; set; }
        public int FurnitureCategoryId { get; set; }
        public string FurnitureDescription { get; set; }
        public string FurnitureImage { get; set; }


        public FurnitureBrand FurnitureBrand { get; set; }
        public FurnitureCategory FurnitureCategory { get; set; }
    }
}
