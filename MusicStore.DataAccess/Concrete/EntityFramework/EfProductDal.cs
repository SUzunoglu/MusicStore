using MusicStore.DataAccess.Abstract;
using MusicStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MusicStore.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, MusicStoreContext>, IProductDal
    {
        
    }
}
