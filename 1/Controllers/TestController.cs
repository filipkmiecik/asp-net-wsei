using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public String ReturnCurrentDate()
        {

        }

        public IActionResult RedirectToGoogle()
        {
            return Redirect("http://www.google.com");
        }
    }
}
