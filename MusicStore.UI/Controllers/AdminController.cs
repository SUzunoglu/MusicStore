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
        private ICategoryService _categoryService;

        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult ProductList()
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
                Price = model.Price,
                Description = model.Description,
                ImageUrl = model.ImageUrl
            };

            _productService.Add(entity);

            return RedirectToAction("ProductList");
        }

        public IActionResult EditProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _productService.GetById((int)id);

            if (entity == null)
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
        public IActionResult EditProduct(ProductModel model)
        {
            var entity = _productService.GetById(model.Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.Name = model.Name;
            entity.Description = model.Description;
            entity.ImageUrl = model.ImageUrl;
            entity.Price = model.Price;

            _productService.Update(entity);

            return RedirectToAction("ProductList");
        }

        [HttpPost]
        public IActionResult DeleteProduct(int productId)
        {
            var entity = _productService.GetById(productId);

            if (entity != null)
            {
                _productService.Delete(entity);
            }

            return RedirectToAction("ProductList");
        }

        public IActionResult CategoryList()
        {
            CategoryListModel model = new CategoryListModel()
            {
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(CategoryModel model)
        {
            var entity = new Category()
            {
                Name = model.Name
            };

            _categoryService.Add(entity);

            return RedirectToAction("CategoryList");
        }

        public IActionResult EditCategory(int id)
        {
            var entity = _categoryService.GetByIdWithProducts(id);

            CategoryModel model = new CategoryModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Products = entity.ProductCategories.Select(p => p.Product).ToList()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult EditCategory(CategoryModel model)
        {
            var entity = _categoryService.GetById(model.Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.Name = model.Name;
            _categoryService.Update(entity);

            return RedirectToAction("CategoryList");
        }

        [HttpPost]
        public IActionResult DeleteCategory(int categoryId)
        {
            var entity = _categoryService.GetById(categoryId);

            if (entity != null)
            {
                _categoryService.Delete(entity);
            }

            return RedirectToAction("CategoryList");
        }
    }
}
