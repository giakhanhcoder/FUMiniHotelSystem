using BusinessObject;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        public static ObservableCollection<Customer> Customers = new ObservableCollection<Customer>();
        private static int countId = 1;

        public static ObservableCollection<Customer> GetCustomers()
        {
            return Customers;
        }

        public static void SaveCustomer(Customer customer)
        {
            customer.CustomerID = countId++;
            Customers.Add(customer);
        }

        public static void UpdateCustomer(Customer customer)
        {
            var existingCustomer = Customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            if (existingCustomer != null)
            {
                existingCustomer.CustomerFullName = customer.CustomerFullName;
                existingCustomer.Telephone = customer.Telephone;
                existingCustomer.EmailAddress = customer.EmailAddress;
                existingCustomer.CustomerBirthday = customer.CustomerBirthday;
                existingCustomer.CustomerStatus = customer.CustomerStatus;
                existingCustomer.Password = customer.Password;
            }
        }

        public static void DeleteCustomer(Customer customer)
        {
            var existingCustomer = Customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            if (existingCustomer != null)
            {
                Customers.Remove(existingCustomer);
            }
        }

        public static Customer GetCustomerById(string id)
        {
            return Customers.FirstOrDefault(c => c.CustomerID.ToString() == id);
        }

        public static Customer GetAccountById(string customerId)
        {
            Customer accountMember = new Customer();
            if (customerId.Equals("admin@FUMiniHotelSystem.com")) // just for demonstration
            {
                accountMember.CustomerID= 1;
                accountMember.EmailAddress = customerId;
                accountMember.Password = "123";
            }
            return accountMember;
        }
    }
}
