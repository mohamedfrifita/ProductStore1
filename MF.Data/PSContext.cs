using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MF.Domain;

namespace MF.Data
{
 public   class PSContext:DbContext
    {
        public DbSet <Product> Product{ get; set; }
        public DbSet <Provider> Providers{ get; set; }
        public DbSet <Category> Categories{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source= (localDb)\MSSQLLOCALDB; Initial Catalog=ProductStoreDb4se3;integrated security=true");
        }
        public PSContext()
        {
            Database.EnsureCreated();
        }
    }
}
