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
        public IActionResult Index() 
        {
            return View(MockData.categories);
        }
    }
}
