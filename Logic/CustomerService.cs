﻿using System;
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
            try {
                List<Customer> customers = customerDAO.GetAll();
                return customers;
            }
            catch {
                List<Customer> customers = new List<Customer>();
                Customer customer = new Customer {
                    Id = 100,
                    Name = "De Test"
                };
                customers.Add(customer);

                return customers;
            }
        }
        public Customer GetBySurname(string surname) {
            try {
                Customer customer = customerDAO.GetBySurname(surname);
                return customer;
            } catch {
                Customer customer = new Customer {
                    Id = 101,
                    Name = "Tester"
                };

                return customer;
            }
        }
    }
}
