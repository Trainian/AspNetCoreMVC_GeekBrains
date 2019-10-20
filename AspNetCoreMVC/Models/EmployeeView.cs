using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVC.Models
{
   public class EmployeeView
   {
      public int id { get; set; }

      [Required(AllowEmptyStrings = false, ErrorMessage = "Значение не может быть пустым")]
      [Display(Name = "Имя", Description = "Дополнительное сообщение")]
      [StringLength(255, MinimumLength = 1, ErrorMessage = "Значение должно быть от 1 до 255 символов")]
      public string Name { get; set; }

      [Required(AllowEmptyStrings = false, ErrorMessage = "Значение не может быть пустым")]
      [Display(Name = "Фамилия", Description = "Дополнительное сообщение")]
      [StringLength(255, MinimumLength = 1, ErrorMessage = "Значение должно быть от 1 до 255 символов")]
      public string Surname { get; set; }

      [Display(Name = "Отчество", Description = "Дополнительное сообщение")]
      [StringLength(255, ErrorMessage = "Значение должно быть больше 255 символов")]
      public string Patronymic { get; set; }

      [Display(Name = "Дата Рождения")]
      [Required(AllowEmptyStrings = false, ErrorMessage = "Значение не может быть пустым")]
      [DataType(DataType.DateTime)]
      [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
   }
}
