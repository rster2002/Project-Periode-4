using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL {
    public class CustomerDAO:SQLInterface<Customer> {
        public override Customer ProcessRecord(Record record) {
            return new Customer() {
                Id = (int) record["CustomerId"],
                Name = (string) record["CustomerSurname"]
            };
        }
        
        public override List<Customer> GetAll() {
            Line("SELECT CustomerId, CustomerSurname");
            Line("FROM [Customer]");

            return Execute();
        }

        public override Customer GetById(int id) {
            Line("SELECT CustomerId, CustomerSurname");
            Line("FROM [Customer]");
            Line("WHERE [CustomerId] = @id");

            Param("id", id);

            return Execute()[0];
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
