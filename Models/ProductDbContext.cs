using System;
using Microsoft.EntityFrameworkCore;

namespace PhoneShop.Models
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Specification> Specification { get; set; }
        public DbSet<Pictures> Pictures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=phone-shop.db");
        }
    }
}