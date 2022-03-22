using Microsoft.AspNetCore.Mvc;
using Project02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project02.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

      
    }
}
