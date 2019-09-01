using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVC.Models
{
   public class EmployeeView
   {
      public int id { get; set; }
      public string Name { get; set; }
      public string Surname { get; set; }
      public string Patronymic { get; set; }
      public DateTime BirthDate { get; set; }
   }
}
