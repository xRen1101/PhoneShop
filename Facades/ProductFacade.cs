using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PhoneShop.Models;
using PhoneShop.Extensions;

namespace PhoneShop.Facades 
{
    public class ProductFacade : IProductFacade
    {
        private ProductDbContext _dbContext;

        public ProductFacade(ProductDbContext dbContext) {
            _dbContext = dbContext;
        }

        public List<Product> GetPrudocts(string manufacturer = null, string storage = null, string os = null) 
        {
            var productsQuery = _dbContext.Products
                .Include(p => p.Specifications)
                .Include(p => p.Pictures)
                .ApplyFilter(manufacturer, "Manufacturer")
                .ApplyFilter(storage, "Storage")
                .ApplyFilter(os, "OS");

            return productsQuery.ToList();
        }
    }
}