//using MusicStore.DataAccess.Abstract;
//using MusicStore.Entities.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq.Expressions;
//using System.Text;

//namespace MusicStore.DataAccess.Concrete.Memory
//{
//    public class MemoryProductDal : IProductDal
//    {
//        public void Add(Product entity)
//        {
//            throw new NotImplementedException();
//        }

//        public void Delete(Product entity)
//        {
//            throw new NotImplementedException();
//        }

//        public Product Get(Expression<Func<Product, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
//        {
//            var products = new List<Product>()
//            {
//                new Product{Id=1,Name="Gibson",ImageUrl="1.jpg",Price=5000},
//                new Product{Id=2,Name="Fender",ImageUrl="2.jpg",Price=4000},
//                new Product{Id=3,Name="Jackson",ImageUrl="3.jpg",Price=3000}
//            };
//            return products;
//        }

//        public Product GetById(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public Product GetProductDetails(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Product entity)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
