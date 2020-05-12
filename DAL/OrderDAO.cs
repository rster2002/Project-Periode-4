using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL {
    public class OrderDAO:SQLInterface<Order> {
        public List<Order> GetAll() {
            Line("SELECT *");
            Line("FROM [Order]");

            return execute();
        }

        public Order GetById(int id) {
            Line("SELECT *");
            Line("FROM [Order]");
            Line("WHERE [OrderId] = @id");

            Param("id", id);

            return Execute()[0];
        }

        protected override Order ProcessRecord(Record record) {
            return new Order() {
                Id = (int) record["OrderId"],
                PlacedBy = null, // TODO: Reference StaffDAO
                Table = null, // TODO: Reference TableDAO
            };
        }
    }
}
