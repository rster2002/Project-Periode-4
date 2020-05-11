using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logic {
    public class CustomerService {

        private CustomerDAO customerDAO = new CustomerDAO();

        public List<Customer> GetAllCustomers() {
            List<Customer> customers = customerDAO.GetAll();
            return customers;
        }
        public Customer GetBySurname(string surname) {
            Customer customer = customerDAO.GetBySurname(surname);
            return customer;
        }
    }
}
