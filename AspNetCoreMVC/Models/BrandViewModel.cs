using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMvc.Domain;
using AspNetCoreMvc.Domain.Entities.Base;

namespace AspNetCoreMVC.Models
{
    public class BrandViewModel : Brand
    {
        /// <summary>
        /// Количество товаров бренда
        /// </summary>
        public int ProductsCount { get; set; }
        
    }
}
