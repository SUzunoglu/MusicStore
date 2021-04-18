using MusicStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Business.Abstract
{
    public interface ICategoryService
    {
        void Add(Category entity);
        void Update(Category entity);
        void Delete(Category entity);

        List<Category> GetAll();
        Category GetById(int id);
        Category GetByIdWithProducts(int id);
        void DeleteFromCategory(int categoryId, int productId);
    }
}
