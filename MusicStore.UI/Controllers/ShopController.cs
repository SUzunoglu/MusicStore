using Microsoft.AspNetCore.Mvc;
using MusicStore.Business.Abstract;
using MusicStore.Entities.Concrete;
using MusicStore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.UI.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductService _productService;

        public ShopController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult List()
        {
            ProductListModel model = new ProductListModel
            {
                Products = _productService.GetAll()
            };

            return View(model);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product product = _productService.GetProductDetails((int)id);

            if (product == null)
            {
                return NotFound();
            }

            ProductDetailsModel model = new ProductDetailsModel
            {
                Product = product,
                Categories = product.ProductCategories.Select(i => i.Category).ToList()
            };
            return View(model); 
        }
    }
}
