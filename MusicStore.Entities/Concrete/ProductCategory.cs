using MusicStore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Entities.Concrete
{
    public class ProductCategory : IEntity
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
