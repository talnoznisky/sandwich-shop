//one page that contains cart view and uses cart data model


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SandwichShop.Models;
using SandwichShop.Data;


namespace SandwichShop.Data
{
    public class CartController : Controller
    {
        public IActionResult Index(int id)
        {
            Cart cart = new Cart();
           foreach(var category in MockData.categories)
            {
                foreach(var product in category.Products)
                {
                    if(product.ID == id)
                    {
                        cart.Cartproducts.Add(product);
                    }
                }
            }

            return View(cart);
        }
    }
}
