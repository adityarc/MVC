using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tryingmvc.Models;

namespace tryingmvc.Controllers
{
    
    public class ProductsController : Controller
    {
      public ActionResult Index()
        {
            var Product = new Products
            {
                ProductID = 101,
                ProductName = "Cell Phone",
                Price = 25000,
                Quantity = 50

            };            return View(Product);
        }

    }
}