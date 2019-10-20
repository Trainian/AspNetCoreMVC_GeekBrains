using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMvc.Domain.Entities.Base;

namespace AspNetCoreMVC.Models
{
    public class SectionViewModel : OrderedEntity
    {
        public SectionViewModel()
        {
            ChildSections = new List<SectionViewModel>();
        }

        /// <summary>
        /// Дочерние секции
        /// </summary>
        public List<SectionViewModel> ChildSections { get; set; }

        /// <summary>
        /// Родительская секция
        /// </summary>
        public SectionViewModel ParentSection { get; set; }

    }
}
