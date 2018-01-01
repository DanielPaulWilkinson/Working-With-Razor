using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkingWithRazor.Models;

namespace WorkingWithRazor.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //Product Kayak = new Product
            //{
            //    Name = "Kayak",
            //    Desc = "A one man boat.",
            //    price = 10,
            //    ProductID = 1,
            //    Category = "Boat"

            //};

            //ViewBag.StockLevel = 2;

            Product[] product =
            {
                new Product { Name="lol", price=0 },
                new Product { Name="lol1", price=10 },
                new Product { Name="lol2", price=20 },

            };
            return View(product);
        }
    }
}