using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SandwichShop.Models;
using SandwichShop.Data;

namespace SandwichShop.Controllers
{
    public class ShopController : Controller
    {

        private ApplicationDbContext _context;

        public ShopController(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {

            if (!_context.Categories.Any())
            {
                _context.Categories.AddRange(MockData.categories);
                _context.SaveChanges();
            }
            return View(MockData.categories);
        }

        public IActionResult Category(int id)
        {
            ICollection<Product> products = null;
            foreach (var category in MockData.categories)
            {
                if(category.ID == id)
                {
                    products = category.Products;
                }
            }

            return View(products);
        }
    }
}
