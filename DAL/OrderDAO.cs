using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL {
    public class OrderDAO:SQLInterface<Order> {
        private void BasicSelect() {
            Line("SELECT *");
            Line("FROM [Order]");
        }

        public override List<Order> GetAll() {
            BasicSelect();

            return Execute();
        }

        public override Order GetById(int id) {
            BasicSelect();
            Line("WHERE [OrderId] = @id");

            Param("id", id);

            return Execute()[0];
        }

        public List<Order> GetByReservationId(int id) {
            BasicSelect();
            Line("WHERE [ReservationId] = @id");

            Param("id", id);

            return Execute();
        }

        public List<Order> GetByReceiptId(int id) {
            BasicSelect();
            Line("WHERE [ReceiptId] = @id");

            Param("id", id);

            return Execute();
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
