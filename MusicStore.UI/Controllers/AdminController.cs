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
    public class AdminController : Controller
    {
        private IProductService _productService;

        public AdminController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            ProductListModel model = new ProductListModel
            {
                Products = _productService.GetAll()
            };

            return View(model);
        }

        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductModel model)
        {
            var entity = new Product()
            {
                Name = model.Name,
                Price=model.Price,
                Description=model.Description,
                ImageUrl=model.ImageUrl
            };

            _productService.Add(entity);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }

            var entity = _productService.GetById((int)id);

            if (entity==null)
            {
                return NotFound();
            }

            ProductModel model = new ProductModel
            {
                Id = entity.Id,
                Name = entity.Name,
                ImageUrl = entity.ImageUrl,
                Description = entity.Description,
                Price = entity.Price
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ProductModel model)
        {
            var entity = _productService.GetById(model.Id);

            if (entity==null)
            {
                return NotFound();
            }

            entity.Name = model.Name;
            entity.Description = model.Description;
            entity.ImageUrl = model.ImageUrl;
            entity.Price = model.Price;

            _productService.Update(entity);

            return RedirectToAction("Index");
        }
    }
}
