using MusicStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MusicStore.DataAccess.Abstract
{
    
    public interface IProductDal : IEntityRepository<Product>
    {
        Product GetProductDetails(int id);
    }
}
