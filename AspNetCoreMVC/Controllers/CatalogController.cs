using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Products()
        {
            return View();
        }
        public IActionResult Product_Details()
        {
            return View();
        }
    }
}