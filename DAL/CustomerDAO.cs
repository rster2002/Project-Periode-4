using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL {
    public class CustomerDAO:SQLInterface<Customer> {
        protected override Customer ProcessRecord(Record record) {
            return new Customer() {
                Id = (int) record["CustomerId"],
                Name = (string) record["CustomerSurname"]
            };
        }
        public List<Customer> GetAll() {
            Line("SELECT CustomerId, CustomerSurname");
            Line("FROM [Customer]");

            return Execute();
        }
        public Customer GetBySurname(string name) {
            Line("SELECT CustomerId, CustomerSurname");
            Line("FROM [Customer]");
            Line("WHERE [CustomerSurname] = @name");

            Param("name", name);

            return Execute()[0];
        }
    }
}
