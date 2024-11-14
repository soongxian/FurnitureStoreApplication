using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.Data.Models
{
    public class FurnitureBrand
    {
        public int Id { get; set; }
        public string FurnitureBrandName { get; set; }
        public List<Furniture> Furnitures { get; set; }
    }
}
