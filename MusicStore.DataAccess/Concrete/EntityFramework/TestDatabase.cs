//using Microsoft.EntityFrameworkCore;
//using MusicStore.Entities.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace MusicStore.DataAccess.Concrete.EntityFramework
//{
//    public static class TestDatabase
//    {
//        public static void Test()
//        {
//            MusicStoreContext context = new MusicStoreContext();

//            if (context.Database.GetPendingMigrations().Count() == 0)
//            {
//                if (context.Categories.Count() == 0)
//                {
//                    context.Categories.AddRange(Categories);
//                }

//                if (context.Products.Count() == 0)
//                {
//                    context.Products.AddRange(Products);
//                }

//                context.SaveChanges();
//            }
//        }

//        private static Category[] Categories =
//        {
//            new Category {Name ="Gitar" },
//            new Category {Name ="Bateri" }
//        };

//        private static Product[] Products =
//        {
//            new Product {Name="Gibson", Price=10000, ImageUrl="1.png"},
//            new Product {Name="Fender", Price=7000, ImageUrl="2.png"},
//            new Product {Name="Jackson", Price=5000, ImageUrl="3.png"},
//        };
//    }
//}
