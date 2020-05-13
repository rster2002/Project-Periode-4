using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Model;

namespace DAL {
    public class ReservationDAO: SQLInterface<Reservation> {
        private void BasicSelect() {
            Line("SELECT *");
            Line("FROM [Reservation]");
        }

        public override List<Reservation> GetAll() {
            BasicSelect();

            return Execute();
        }

        public override Reservation GetById(int id) {
            BasicSelect();
            Line("WHERE [ReservationId] = @id");

            Param("id", id);

            return Execute()[0];
        }

        protected override Reservation ProcessRecord(Record record) {
            OrderDAO orderDAO = new OrderDAO();
            TableDAO tableDAO = new TableDAO();
            Table table = tableDAO.GetById((int) record["TableNumber"]);

            Customer customer = null;
            if (record["Customer"] != DBNull.Value) {
                CustomerDAO customerDAO = new CustomerDAO();
                customer = customerDAO.GetById((int) record["Customer"]);
            }

            int id = (int) record["ReservationId"];
            return new Reservation() {
                Id = id,
                Customer = customer,
                Table = table,
                Orders = orderDAO.GetByReservationId(id)
            };
        }
    }
}
