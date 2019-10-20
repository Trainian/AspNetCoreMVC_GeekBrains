using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMVC.Infrastructure.Interfaces;
using AspNetCoreMVC.Models;

namespace AspNetCoreMVC.Infrastructure.Implementations
{
    /// <inheritdoc />
    /// <summary>
    /// Реализация интерфейса, хранит инфу в памяти
    /// </summary>
    public class InMemoryEmployeesData : IEmployeesData
    {
        private readonly List<EmployeeView> _employees;

        public InMemoryEmployeesData()
        {
            _employees = new List<EmployeeView>(3)
            {
                new EmployeeView(){id = 1, Name = "Вася", Surname = "Пупкин", Patronymic = "Иванович", BirthDate = new DateTime(1991,03,28)},
                new EmployeeView(){id = 2, Name = "Иван", Surname = "Холявко", Patronymic = "Александрович", BirthDate = new DateTime(1987,03,01)},
                new EmployeeView(){id = 3, Name = "Роберт", Surname = "Серов", Patronymic = "Сигизмундович", BirthDate = new DateTime(2000,04,17)}
            };
        }
        public IEnumerable<EmployeeView> GetAll()
        {
            return _employees;
        }

        public EmployeeView GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.id.Equals(id));
        }

        public void Commit()
        {
            // ничего не делаем
        }

        public void AddNew(EmployeeView model)
        {
            model.id = _employees.Max(e => e.id) + 1;
            _employees.Add(model);
        }

        public void Delete(int id)
        {
            var employee = GetById(id);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
        }
    }

}
