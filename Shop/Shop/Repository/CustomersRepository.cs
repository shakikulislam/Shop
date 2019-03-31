using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Shop.Models;

namespace Shop.Repository
{
    public class CustomersRepository
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        private static SqlConnection _sqlConnection = new SqlConnection(_connectionString);
        private static SqlCommand _sqlCommand = new SqlCommand("", _sqlConnection);

        private static SqlDataReader _sqlDataReader;

        public bool Add(Customer customer)
        {
            bool isAdded = false;
            string querry = "INSERT INTO Customers(CustomerId,Name,Code,Address,Email,Contact,Age,LoyalityPoint)" +
                            "VALUES('" + customer.CustomerId + "','" + customer.Name + "','" + customer.Code + "','" +
                            customer.Address + "','" + customer.Email + "','" + customer.Contact + "','" + customer.Age +
                            "','" + customer.LoyalityPoint + "')";

            _sqlConnection.Open();
            _sqlCommand.CommandText = querry;
            int isExecute = _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
            isAdded = isExecute > 0 ? true : false;
            return isAdded;
        }

        public bool Update(Customer customer)
        {
            bool isUpdate = false;
            string querry = "UPDATE Customers SET CustomerId='" + customer.CustomerId + "',Name='" + customer.Name + "'," +
                            "Code='" + customer.Code + "',Address='" +customer.Address + "',Email='" + customer.Email + "' " +
                            ",Contact='" + customer.Contact + "',Age='" + customer.Age + "',LoyalityPoint='" + customer.LoyalityPoint + "' WHERE CustomerId='" + customer.CustomerId + "'";

            _sqlConnection.Open();
            _sqlCommand.CommandText = querry;
            int isExecute = _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
            isUpdate = isExecute > 0 ? true : false;
            return isUpdate;
        }
        public bool Delete(Customer customer)
        {
            bool isUpdate = false;
            string querry = "DELETE Customers WHERE CustomerId='" + customer.CustomerId + "'";

            _sqlConnection.Open();
            _sqlCommand.CommandText = querry;
            int isExecute = _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
            isUpdate = isExecute > 0 ? true : false;
            return isUpdate;
        }


        public List<Customer> Show(int index)
        {
            List<Customer> customerList = new List<Customer>();
            string querry = "SELECT *FROM Customers";
            _sqlConnection.Open();
            _sqlCommand.CommandText = querry;
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                var customers = new Customer();
                customers.SlNo = index;
                customers.CustomerId = Convert.ToInt32(_sqlDataReader["CustomerId"].ToString());
                customers.Name = _sqlDataReader["Name"].ToString();
                customers.Code = _sqlDataReader["Code"].ToString();
                customers.Address = _sqlDataReader["Address"].ToString();
                customers.Email = _sqlDataReader["Email"].ToString();
                customers.Contact = Convert.ToInt32(_sqlDataReader["Contact"].ToString());
                customers.Age = Convert.ToInt32(_sqlDataReader["Age"]);
                customers.LoyalityPoint = Convert.ToInt32(_sqlDataReader["LoyalityPoint"].ToString());

                customerList.Add(customers);
                index++;
            }
            _sqlConnection.Close();

            return customerList;

        }
    }
}