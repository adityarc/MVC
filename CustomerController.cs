using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tryingmvc.Models;

namespace tryingmvc.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult CustomerIndex()
        {
            var Cust = GetCustomers();
              
             return View(Cust);
        }

        public List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {CustomerID = 1, CustomerName = "Abhishek", City = "kolkata", Phone = "9874237432" },
                new Customer {CustomerID = 2, CustomerName = "Raja", City = "Chennai", Phone = "9823437432" },
                new Customer {CustomerID = 3, CustomerName = "Kiran", City = "Chennai", Phone = "9875677432" },
                new Customer {CustomerID = 4, CustomerName = "Archi", City = "kolkata", Phone = "9872564432" },

            };
        }
    }
}