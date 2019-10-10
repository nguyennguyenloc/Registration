using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Registration.Models;

namespace Registration.Controllers
{
    public class HomeController : Controller
    {
       /* public IActionResult Index()
        {
            return View();
        }*/
        public ViewResult index()
        {
            return View("myView");
        }
        public String Index2()
        {
            return "Hello Lộc, you can do it";
        }

        
    }
}
