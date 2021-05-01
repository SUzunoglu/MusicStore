﻿using MusicStore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
