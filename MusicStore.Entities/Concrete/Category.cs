using MusicStore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
