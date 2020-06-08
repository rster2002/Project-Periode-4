using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Model {
    public class CustomerService {

        private CustomerDAO customerDAO = new CustomerDAO();

        public List<Customer> GetAllCustomers() {
            return customerDAO.GetAll();
        }
        public Customer GetBySurname(string surname) {
            return customerDAO.GetBySurname(surname);
        }
    }
}
