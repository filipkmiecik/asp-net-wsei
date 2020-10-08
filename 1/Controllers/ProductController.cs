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
            var model = new ProductModel {name = "abc", description = "abc", price = 30 };
            return View(model);
        }
    }
}
