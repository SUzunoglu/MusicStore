using MusicStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Business.Abstract
{
    public interface IProductService
    {
        void Add(Product entity);
        void Update(Product entity);
        void Delete(Product entity);

        Product GetById(int id);
        Product GetProductDetails(int id);
        List<Product> GetAll();
    }
}
