using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Customer
    {
        public int? SlNo { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Contact { get; set; }
        public int Age { get; set; }
        public int LoyalityPoint { get; set; }
    }
}