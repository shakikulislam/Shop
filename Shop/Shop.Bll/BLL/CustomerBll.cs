using System.Collections.Generic;
using Shop.Models;
using Shop.Repository;

namespace Shop.BLL
{
    public class CustomerBll
    {
        CustomersRepository _customers = new CustomersRepository();

        public bool Add(Customer customer)
        {
            return _customers.Add(customer);
        }

        public bool Update(Customer customer)
        {
            return _customers.Update(customer);
        }
        public bool Delete(Customer customer)
        {
            return _customers.Delete(customer);
        }

        public Customer GetCustomerById(int id)
        {
            return _customers.GetCustomerById(id);
        }

        public List<Customer> Search()
        {
            var dataList = _customers.Search();
            return dataList;
        }
    }
}