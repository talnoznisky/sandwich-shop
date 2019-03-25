using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandwichShop.Data
{
    public class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }
        public int ID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}