using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC.Controllers
{
   public class HomeController : Controller
   {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Checkout ()
        {
            return View();
        }

        public IActionResult Cart ()
        {
            return View();
        }

        public IActionResult Login ()
        {
            return View();
        }

        public IActionResult Blog_List ()
        {
            return View();
        }

        public IActionResult Blog_Single ()
        {
            return View();
        }

        public IActionResult Contact ()
        {
            return View();
        }

        public IActionResult Error ()
        {
            return View();
        }
   }
}