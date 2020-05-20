using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL {
    public class OrderDAO: SQLInterface<Order> {
        private void BasicSelect() {
            Line("SELECT *");
            Line("FROM [Order]");
            Line("JOIN [Staff] ON [Order].OrderPlacedBy = [Staff].StaffNumber");
            Line("JOIN [OrderItem] ON [Order].OrderId = [OrderItem].OrderId");
            Line("JOIN [MenuItem] ON [OrderItem].MenuItemId = [MenuItem].MenuItemId");
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

        public void DeleteById(int id) {
            Line("DELETE [Reservation]");
            Line("WHERE [ReservationId] = @id");

            Param("id", id);

            Execute();
        }

        protected override List<Order> ProcessRecords(List<Record> records) {
            Dictionary<int, Order> ordersMap = new Dictionary<int, Order>();

            foreach (Record record in records) {
                int orderId = (int) record["OrderId"];

                if (!ordersMap.ContainsKey(orderId)) {
                    ordersMap[orderId] = ProcessRecord(record);
                }

                ordersMap[orderId].MenuItems.Add(new MenuItem() {
                    Id = (int) record["MenuItemId"],
                    Name = (string) record["MenuItemName"],
                    Price = (decimal) record["Price"],
                    VAT = (int) record["VAT"],
                    AmountInStock = (int) record["InStock"],
                    Comment = (string) record["Comment"]
                });
            }

            return ordersMap.Values.ToList();
        }

        protected override Order ProcessRecord(Record record) {
            return new Order() {
                Id = (int) record["OrderId"],
                PlacedBy = new Staff() {
                    Id = (int) record["StaffNumber"],
                    Name = (string) record["StaffName"],
                    Salt = (int) record["StaffSalt"],
                    Role = (string) record["StaffRole"]
                },
                PlacedAt = (DateTime) record["OrderPlacedDateTime"]
            };
        }
    }
}
