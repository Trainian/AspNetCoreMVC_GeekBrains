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
         public static List<EmployeeView> _employees = new List<EmployeeView>
         {
            new EmployeeView
            {
               id = 1,
               Name = "Дмитрий",
               Surname = "Горбовский",
               Patronymic = "Владмирович",
               BirthDate = new DateTime(1991,03,28)
            },
            new EmployeeView
            {
               id = 2,
               Name = "Алина",
               Surname = "Котар",
               Patronymic = "Сергеевна",
               BirthDate = new DateTime(1994,07,22)
            }
         };
        public IActionResult Index()
        {
            return View(_employees);
        }
        public IActionResult ViewModel(int id)
        {
            var employee = _employees.FirstOrDefault(t => t.id == id);
            if (ReferenceEquals(employee, null))
               return NotFound();
            return View(employee);
        }
   }
}