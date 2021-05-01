using MusicStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.UI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "Ürün ismi min. 5, max. 45 karakter olmalıdır.")]
        //[StringLength(45, MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Ürün açıklması min. 10, max. 100 karakter olmalıdır.")]
        [StringLength(100, MinimumLength = 10)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Lütfen ürün fiyatı giriniz.")]
        [Range(1, 1000000)]
        public decimal? Price { get; set; }

        public List<Category> SelectedCategories { get; set; }
    }
}
