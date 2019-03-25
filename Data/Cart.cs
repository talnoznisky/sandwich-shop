//ICollection or other enumerable object that accumulates objects of product class
//eventually should have order ID value as well
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandwichShop.Data
{
    public class Cart
    {
        public Cart()
        {
            this.Cartproducts = new HashSet<Product>();
        }
        public ICollection<Product> Cartproducts { get; set; }
    }
}
