using System.Collections.Generic;
using Shop.Models;
using Shop.Repository;

namespace Shop.BLL
{
    public class CustomerBll
    {
        CustomersRepository customersRepository = new CustomersRepository();

        public bool Add(Customer customer)
        {
            var isSaved= customersRepository.Add(customer);
            return isSaved;
        }

        public bool Update(Customer customer)
        {
            var isUpdate = customersRepository.Update(customer);
            return isUpdate;
        }
        public bool Delete(Customer customer)
        {
            var isDelete = customersRepository.Delete(customer);
            return isDelete;
        }

        public List<Customer> Show(int index)
        {
            return customersRepository.Show(index);
        }
    }
}