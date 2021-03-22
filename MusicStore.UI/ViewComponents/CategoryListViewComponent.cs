using Microsoft.AspNetCore.Mvc;
using MusicStore.Business.Abstract;
using MusicStore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.UI.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        private ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            CategoryListViewModel model = new CategoryListViewModel()
            {
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }
    }
}
