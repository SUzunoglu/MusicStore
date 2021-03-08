using Microsoft.EntityFrameworkCore;
using MusicStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.DataAccess.Concrete.EntityFramework
{
    public class MusicStoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database= MusicStore; Trusted_Connection = true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; } 
    }
}
