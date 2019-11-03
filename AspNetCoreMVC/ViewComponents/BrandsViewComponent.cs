using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMVC.Infrastructure.Interfaces;
using AspNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC.ViewComponents
{
    public class BrandsViewComponent : ViewComponent
    {
        private IProductData _productData;

        public BrandsViewComponent(IProductData productData)
        {
            _productData = productData;
        }

        public IViewComponentResult Invoke()
        {
            var brands = GetBrands();
            return View(brands);
        }

        private List<BrandViewModel> GetBrands()
        {
            var dbBrands = _productData.GetBrands();
            return dbBrands.Select(x => new BrandViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Order = x.Order,
                ProductsCount = _productData.GetProductCount(x.Id)
            }).OrderBy(b => b.Order).ToList();
        }
    }
}
