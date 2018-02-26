using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tryingmvc.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
    }

}