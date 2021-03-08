using MusicStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        void Add(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
    }
}
