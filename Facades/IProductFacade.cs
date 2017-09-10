using System.Collections.Generic;
using PhoneShop.Models;

namespace PhoneShop.Facades 
{
    public interface IProductFacade
    {
        List<Product> GetPrudocts(string manufacturer = null, string storage = null, string os = null);
    }
}