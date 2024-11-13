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
        public FurnitureBrand FurnitureBrand { get; set; }
        public FurnitureCategory FurnitureCategory { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
    }
}
