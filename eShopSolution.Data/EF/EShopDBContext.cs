using eShopSolution.Data.Entities;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.EF
{
    public class EShopDBContext : DbContext
    {
        public EShopDBContext( DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get ; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
