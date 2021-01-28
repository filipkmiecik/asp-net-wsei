using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.Controllers
{
    public class ChatController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
