using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PhoneShop.Models;

namespace PhoneShop.Facades 
{
    public class ProductFacade : IProductFacade
    {
        private ProductDbContext _dbContext;

        public ProductFacade(ProductDbContext dbContext) {
            _dbContext = dbContext;
        }

        public List<Product> GetPrudocts() 
        {
            return _dbContext.Products
                .Include(p => p.Specifications)
                .Include(p => p.Pictures)
                .ToList();
        }
    }
}