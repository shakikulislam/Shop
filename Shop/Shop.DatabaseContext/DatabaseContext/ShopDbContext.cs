using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Shop.Models;


namespace Shop.DatabaseContext
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}