using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMvc.Domain.Entities.Base.Interfaces;

namespace AspNetCoreMVC.Models
{
    public class ProductViewModel: Product

    {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Order { get; set; }
    public string ImageUrl { get; set; }
    public decimal Price { get; set; }

    }
}
