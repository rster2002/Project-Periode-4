using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL {
    public class OrderDAO:SQLInterface<Order> {
        public List<Order> getAll() {
            line("SELECT *");
            line("FROM [Order]");

            return execute();
        }

        public Order getById(int id) {
            line("SELECT *");
            line("FROM [Order]");
            line("WHERE [OrderId] = @id");

            param("id", id);

            return execute()[0];
        }

        protected override Order processRecord(Record record) {
            return new Order() {
                id = (int) record["OrderId"],
                placedBy = null, // TODO: Reference StaffDAO
                table = null, // TODO: Reference TableDAO
            };
        }
    }
}
