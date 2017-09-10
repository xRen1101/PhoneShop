using System.Linq;
using PhoneShop.Models;

namespace PhoneShop.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<Product> ApplyFilter(this IQueryable<Product> query, string filter, string filterType)
        {
            if (!string.IsNullOrEmpty(filter)) 
            {
                var filters = filter.Split(',');
                query = query
                    .Where(p => filters.Contains(p.Specifications.FirstOrDefault(s => s.Type == filterType).Value));
            }

            return query;
        }
    }   
}