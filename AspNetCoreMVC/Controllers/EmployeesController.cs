using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMVC.Infrastructure.Interfaces;
using AspNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AspNetCoreMVC.Controllers
{
    [Route("Users")]
    public class EmployeesController : Controller
    {
        private IEmployeesData _employeesData;
        public EmployeesController(IEmployeesData employeesData)
        {
            _employeesData = employeesData;
        }
        public IActionResult Users()
        {
            return View(_employeesData.GetAll());
        }

        [Route("{id}")]
        public IActionResult ViewModel(int id)
        {
            var employee = _employeesData.GetById(id);
            if (ReferenceEquals(employee, null))
                return NotFound();
            return View(employee);
        }
        /// <summary>
        /// Добавление или редактирование сотрудника
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            EmployeeView model;
            if (id.HasValue)
            {
                model = _employeesData.GetById(id.Value);
                if (ReferenceEquals(model, null))
                    return NotFound();// возвращаем результат 404 Not Found
            }
            else
            {
                model = new EmployeeView();
            }
            return View(model);
        }

        [HttpPost]
        [Route("edit/{id?}")]
        public IActionResult Edit(EmployeeView model)
        {
            if (model.BirthDate >= DateTime.Now)
            {
                ModelState.AddModelError("BirthDate", "Не верная дата рождения");
            }

            if (ModelState.IsValid)
            {
                if (model.id > 0)
                {
                    var dbItem = _employeesData.GetById(model.id);

                    if (ReferenceEquals(dbItem, null))
                        return NotFound(); // возвращаем результат 404 Not Found

                    dbItem.Name = model.Name;
                    dbItem.Surname = model.Surname;
                    dbItem.BirthDate = model.BirthDate;
                    dbItem.Patronymic = model.Patronymic;
                }
                else
                {
                    _employeesData.AddNew(model);
                }

                _employeesData.Commit();

                return RedirectToAction(nameof(Users));
            }
            else return View(model);
        }

        /// <summary>
        /// Удаление сотрудника
        /// </summary>
        /// <param name="id">Id сотрудника</param>
        /// <returns></returns>
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _employeesData.Delete(id);
            return RedirectToAction(nameof(Users));
        }

    }
}