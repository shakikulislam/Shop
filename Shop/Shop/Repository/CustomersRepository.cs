using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using Shop.DatabaseContext;
using Shop.Models;

namespace Shop.Repository
{
    public class CustomersRepository
    {
        ShopDbContext shopDb=new ShopDbContext();

        public bool Add(Customer customer)
        {
            shopDb.Customers.Add(customer);
            var isSaved = shopDb.SaveChanges();
            return isSaved > 0 ? true : false;
            
        }

        public bool Update(Customer customer)
        {
            shopDb.Entry(customer).State=EntityState.Modified;
            var isUpdate = shopDb.SaveChanges();
            return isUpdate > 0 ? true : false;
        }
        public bool Delete(Customer customer)
        {
            shopDb.Customers.Remove(customer);
            var isDelete = shopDb.SaveChanges();
            return isDelete > 0 ? true : false;
        }


        public Customer GetCustomerById(int id)
        {
            var customer = shopDb.Customers.FirstOrDefault(c => c.CustomerId == id);
            return customer;
        }

        public List<Customer> Search()
        {
            return shopDb.Customers.ToList();
        }
    }
}