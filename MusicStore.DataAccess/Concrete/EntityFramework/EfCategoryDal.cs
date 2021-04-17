using Microsoft.EntityFrameworkCore;
using MusicStore.DataAccess.Abstract;
using MusicStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MusicStore.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, MusicStoreContext>, ICategoryDal
    {
        public Category GetByIdWithProducts(int id)
        {
            using (var context = new MusicStoreContext())
            {
                return context.Categories
                               .Where(i => i.Id == id)
                               .Include(i => i.ProductCategories)
                               .ThenInclude(i => i.Product)
                               .FirstOrDefault();
            }
        }
    }
}
