using System.Collections.Generic;
using PhoneShop.Models;

namespace PhoneShop.Facades 
{
    public interface IProductFacade
    {
        List<Product> GetPrudocts();
    }
}