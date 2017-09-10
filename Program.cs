using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PhoneShop.Data;
using PhoneShop.Models;

namespace PhoneShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RepopulateDatabase();
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();

        //this method is used to simplify setup of the project and should be used only for development purposes
        private static void RepopulateDatabase() {
            using (var db = new ProductDbContext())
            {
                db.Specification.RemoveRange(db.Specification);
                db.Pictures.RemoveRange(db.Pictures);
                db.Products.RemoveRange(db.Products);
                db.SaveChanges();
                db.Products.AddRange(Products.GetProducts());
                db.SaveChanges();
            }
        }
    }
}
