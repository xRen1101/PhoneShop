using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneShop.Facades;
using PhoneShop.Models;

namespace PhoneShop.Controllers
{
    public class HomeController : Controller
    {
        private IProductFacade _productFacade;

        public HomeController(IProductFacade productFacade)
        {
            _productFacade = productFacade;
        }
        
        public IActionResult Index()
        {
            var products = _productFacade.GetPrudocts();
            
            return View(products);
        }

        [HttpGet]
        public IActionResult GetProducts(string manufacturer, string storage, string os)
        {
            var products = _productFacade.GetPrudocts(manufacturer, storage, os);

            return Json(products);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
