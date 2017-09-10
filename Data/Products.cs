using System;
using System.Collections.Generic;
using PhoneShop.Models;

namespace PhoneShop.Data
{
    //todo: import products straight from the products.json file
    public static class Products
    {
        public static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product 
                {
                    Name = "Sony Xperia Z4",
                    Price = 899,
                    Specifications = new List<Specification>
                    {
                        new Specification { Type = "Manufacturer", Value = "Sony" },
                        new Specification { Type = "Storage", Value = "16" },
                        new Specification { Type = "OS", Value = "Android" },
                        new Specification { Type = "Camera", Value = "15" }
                    },
                    Pictures = new Pictures
                    {
                        Small = "images/sony-xperia-z3.jpg",
                        Large = "images/sony-xperia-z3-large.jpg"
                    }
                },
                new Product 
                {
                    Name = "Iphone 6",
                    Price = 899,
                    Specifications = new List<Specification>
                    {
                        new Specification { Type = "Manufacturer", Value = "Apple" },
                        new Specification { Type = "Storage", Value = "16" },
                        new Specification { Type = "OS", Value = "iOS" },
                        new Specification { Type = "Camera", Value = "8" }
                    },
                    Pictures = new Pictures
                    {
                        Small = "images/iphone6.jpg",
                        Large = "images/iphone6-large.jpg"
                    }
                },
                new Product 
                {
                    Name = "HTC One M8",
                    Price = 899,
                    Specifications = new List<Specification>
                    {
                        new Specification { Type = "Manufacturer", Value = "HTC" },
                        new Specification { Type = "Storage", Value = "32" },
                        new Specification { Type = "OS", Value = "Android" },
                        new Specification { Type = "Camera", Value = "5" }
                    },
                    Pictures = new Pictures
                    {
                        Small = "images/htc-one.jpg",
                        Large = "images/htc-one-large.jpg"
                    }
                },
                new Product 
                {
                    Name = "Galaxy Alpha",
                    Price = 899,
                    Specifications = new List<Specification>
                    {
                        new Specification { Type = "Manufacturer", Value = "Samsung" },
                        new Specification { Type = "Storage", Value = "32" },
                        new Specification { Type = "OS", Value = "Android" },
                        new Specification { Type = "Camera", Value = "12" }
                    },
                    Pictures = new Pictures
                    {
                        Small = "images/galaxy-alpha.jpg",
                        Large = "images/galaxy-alpha-large.jpg"
                    }
                },
                new Product 
                {
                    Name = "Nokia Lumia",
                    Price = 450,
                    Specifications = new List<Specification>
                    {
                        new Specification { Type = "Manufacturer", Value = "Nokia" },
                        new Specification { Type = "Storage", Value = "16" },
                        new Specification { Type = "OS", Value = "Windows" },
                        new Specification { Type = "Camera", Value = "5" }
                    },
                    Pictures = new Pictures
                    {
                        Small = "images/nokia-lumia.jpg",
                        Large = "images/nokia-lumia-large.jpg"
                    }
                },
                new Product 
                {
                    Name = "Zte Nubia",
                    Price = 399,
                    Specifications = new List<Specification>
                    {
                        new Specification { Type = "Manufacturer", Value = "ZTE" },
                        new Specification { Type = "Storage", Value = "32" },
                        new Specification { Type = "OS", Value = "Android" },
                        new Specification { Type = "Camera", Value = "12" }
                    },
                    Pictures = new Pictures
                    {
                        Small = "images/zte-nubia.jpg",
                        Large = "images/zte-nubia-large.jpg"
                    }
                },
                new Product 
                {
                    Name = "Samsung Galaxy S5",
                    Price = 399,
                    Specifications = new List<Specification>
                    {
                        new Specification { Type = "Manufacturer", Value = "Samsung " },
                        new Specification { Type = "Storage", Value = "16" },
                        new Specification { Type = "OS", Value = "Android" },
                        new Specification { Type = "Camera", Value = "15" }
                    },
                    Pictures = new Pictures
                    {
                        Small = "images/galaxy-s5.jpg",
                        Large = "images/galaxy-s5-large.jpg"
                    }
                },
                new Product 
                {
                    Name = "Iphone 5S",
                    Price = 399,
                    Specifications = new List<Specification>
                    {
                        new Specification { Type = "Manufacturer", Value = "Apple" },
                        new Specification { Type = "Storage", Value = "16" },
                        new Specification { Type = "OS", Value = "iOS" },
                        new Specification { Type = "Camera", Value = "8" }
                    },
                    Pictures = new Pictures
                    {
                        Small = "images/iphone5s.jpg",
                        Large = "images/iphone5s-large.jpg"
                    }
                }
            };

            return products;
        }
    }
}