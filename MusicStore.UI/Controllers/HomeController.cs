using Microsoft.AspNetCore.Mvc;
using MusicStore.Business.Abstract;
using MusicStore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View(new ProductListModel 
            { 
                Products = _productService.GetAll() 
            });
        }
    }
}
