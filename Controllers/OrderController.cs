//takes cart info and adds to shipping/payment info
//use on index of order views 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SandwichShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace SandwichShop.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(OrderViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                Console.WriteLine("Processing an order from " + model.ContactEmail);

                return RedirectToAction("receipt", "order", model);
            }
            return View(model);
        }

        public IActionResult Receipt(OrderViewModel model)
        {
            return View(model);
        }
    }

}
