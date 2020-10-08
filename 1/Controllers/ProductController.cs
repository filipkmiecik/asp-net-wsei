using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1.Models;
using Microsoft.AspNetCore.Mvc;

namespace _1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public String ReturnCurrentDate()
        {
            DateTime thisDay = DateTime.Today;
            return thisDay.ToString();
        }

        public IActionResult RedirectToGoogle()
        {
            return Redirect("http://www.google.com");
        }

        public IActionResult ProductModel()
        {
            var model = new List<ProductModel>
            {   
            new ProductModel {name = "Shoes", description = "Yellow sneakers", price = 70 },
            new ProductModel {name = "Blu-ray movie", description = "Shrek 3", price = 49 },
            new ProductModel {name = "Sweatshirt", description = "A blue sweatshirt", price = 30 },};
            return View(model);
        }
    }
}
