using System;
using System.Collections.Generic;

namespace PhoneShop.Models
{
    public class Product 
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public List<Specification> Specifications { get; set; }

        public int PictureId { get; set; }
        public Pictures Pictures { get; set; }
    }
}