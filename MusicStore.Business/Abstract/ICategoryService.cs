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
    }
}
