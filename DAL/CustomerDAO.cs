using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL {
    public class CustomerDAO:SQLInterface<Customer> {
        protected override Customer processRecord(Record record) {
            return new Customer() {
                id = (int) record["CustomerId"],
                name = (string) record["CustomerSurname"]
            };
        }
        public List<Customer> GetAll() {
            line("SELECT CustomerId, CustomerSurname");
            line("FROM [Customer]");

            return execute();
        }
        public Customer GetBySurname(string name) {
            line("SELECT CustomerId, CustomerSurname");
            line("FROM [Customer]");
            line("WHERE [CustomerSurname] = @name");

            param("name", name);

            return execute()[0];
        }
    }
}
