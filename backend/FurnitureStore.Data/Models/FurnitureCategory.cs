using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.Data.Models
{
    public class FurnitureCategory
    {
        public int Id { get; set; }
        public string FurnitureCategoryName { get; set; }
        public List<Furniture> Furnitures { get; set; }
    }
}