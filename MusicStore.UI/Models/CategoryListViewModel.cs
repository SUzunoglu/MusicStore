using MusicStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.UI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public string SelectedCategory { get; set; }
    }
}
