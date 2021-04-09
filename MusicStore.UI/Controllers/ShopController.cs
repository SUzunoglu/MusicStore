using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MusicStore.Business.Abstract;
using MusicStore.Entities.Concrete;
using MusicStore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MusicStore.UI.Models.ProductListModel;

namespace MusicStore.UI.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductService _productService;

        public ShopController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult List(string category, int page = 1)
        {
            const int pageSize = 3;
            
            ProductListModel model = new ProductListModel
            {
                PagingInfo = new PagingInfo()
                {
                    TotalItems = _productService.GetCountByCategory(category),
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    CurrentCategory = category
                },
                Products = _productService.GetProductsByCategory(category, page, pageSize)
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
