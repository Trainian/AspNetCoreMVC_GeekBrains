using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMvc.Domain.Entities.Base;
using AspNetCoreMvc.Domain.Entities.Base.Interfaces;

namespace AspNetCoreMVC.Models
{
    /// <inheritdoc cref="NamedEntity" />
    /// <summary>
    /// Сущность продукт
    /// </summary>
    public class Product : OrderedEntity
    {
        /// <summary>
        /// Секция к которой принадлежит товар
        /// </summary>
        public int SectionId { get; set; }

        /// <summary>
        /// Бренд товара
        /// </summary>
        public int? BrandId { get; set; }

        /// <summary>
        /// Ссылка на картинку
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
    }

}
