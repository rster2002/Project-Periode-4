using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Model;

namespace DAL {
    public class ReservationDAO: SQLInterface<Reservation> {
        private void BasicSelect() {
            Line("SELECT *, (");
                Line("SELECT[Customer].CustomerSurname AS CustomerSurname");
                Line("FROM[Customer]");
                Line("WHERE[Reservation].Customer = [Customer].CustomerId");
            Line(") AS CustomerSurname");
            Line("FROM [Reservation]");
            Line("JOIN [Table] ON [Reservation].TableNumber = [Table].TableNumber");
            Line("JOIN [Staff] ON [Table].ServedBy = [Staff].StaffNumber");
            Line("JOIN [Order] ON [Reservation].ReservationId = [Order].ReservationId");
            Line("JOIN [OrderItem] ON [Order].OrderId = [OrderItem].OrderId");
            Line("JOIN [MenuItem] ON [OrderItem].MenuItemId = [MenuItem].MenuItemId");
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

        public void DeleteById(int id) {
            Line("DELETE [Reservation]");
            Line("WHERE [ReservationId] = @id");

            Param("id", id);

            Execute();
        }

        public override Reservation ProcessRecord(Record record) {
            return new Reservation() {
                Id = (int) record["ReservationId"],
                Customer = null,
                Table = new Table() {
                    Number = (int) record["TableNumber"],
                    NumberOfSeats = (int) record["TableSeats"],
                    ServedBy = new Staff() {
                        Id = (int) record["StaffNumber"],
                        Name = (string) record["StaffName"],
                        Salt = (int) record["StaffSalt"],
                        Role = (string) record["StaffRole"]
                    }
        },
                Orders = null
            };
        }

        public override List<Reservation> ProcessRecords(List<Record> records) {
            Dictionary<int, Reservation> reservationMap = new Dictionary<int, Reservation>();
            OrderDAO orderDAO = new OrderDAO();

            foreach (Record record in records) {
                int reservationId = (int) record["ReservationId"];

                if (!reservationMap.ContainsKey(reservationId)) {
                    Reservation reservation = ProcessRecord(record);

                    if (record["Customer"] != DBNull.Value) {
                        reservation.Customer = new Customer() {
                            Id = (int) record["Customer"],
                            Name = (string) record["CustomerSurname"]
                        };
                    }

                    reservation.Orders = orderDAO.ProcessRecords(
                        records
                            .Where(r => (int) r["ReservationId"] == reservationId)
                            .ToList()
                    );

                    reservationMap[reservationId] = reservation;
                }
            }

            return reservationMap.Values.ToList();
        }

        //public override List<Reservation> ProcessRecords(List<Record> records) {
        //    // Create maps for easy lookup when sqashing multiple records into one reservation
        //    Dictionary<int, Reservation> reservationMap = new Dictionary<int, Reservation>();
        //    Dictionary<int, Dictionary<int, Order>> ordersMap = new Dictionary<int, Dictionary<int, Order>>();

        //    // Process every record
        //    foreach (Record record in records) {
        //        // Generate reservation from record
        //        Reservation reservation = ProcessRecord(record);

        //        // Check if reservation id exists in map
        //        if (!reservationMap.ContainsKey(reservation.Id)) {
        //            // Gets required info from record that is 1-on-1
        //            reservation.Table = GetTableFromRecord(record);

        //            if (record["Customer"] != DBNull.Value) {
        //                reservation.Customer = new Customer() {
        //                    Id = (int) record["Customer"],
        //                    Name = (string) record["CustomerSurname"]
        //                };
        //            }

        //            // Adds a map where orders will be added so MenuItems can be mapped
        //            ordersMap.Add(reservation.Id, new Dictionary<int, Order>());

        //            // Adds the reservation object to the reservations map
        //            reservationMap[reservation.Id] = reservation;
        //        }

        //        // Get the orders map for this record's reservation
        //        Dictionary<int, Order> reservationOrderMap = ordersMap[reservation.Id];
        //        int orderId = (int) record["OrderId"];

        //        // Checks if order id exists in orders map for this record's reservation
        //        if (!reservationOrderMap.ContainsKey(orderId)) {
        //            // Adds order to orders map
        //            reservationOrderMap[orderId] = new Order() {
        //                Id = orderId,
        //                PlacedBy = GetStaffFromRecord(record)
        //            };
        //        }

        //        // Adds the menu item to the reservation's order map
        //        reservationOrderMap[orderId].MenuItems.Add(new MenuItem() {
        //            Id = (int) record["MenuItemId"],
        //            Name = (string) record["MenuItemName"],
        //            Price = (decimal) record["Price"],
        //            VAT = (int) record["VAT"],
        //            AmountInStock = (int) record["InStock"],
        //            Comment = (string) record["Comment"]
        //        });
        //    }

        //    // Adds the values from the record's order map to the reservation object stores in the reservations map
        //    foreach (KeyValuePair<int, Dictionary<int, Order>> keyValuePair in ordersMap) {
        //        int reservationId = keyValuePair.Key;
        //        reservationMap[reservationId].Orders = keyValuePair.Value.Values.ToList();
        //    }

        //    // Returns all values from the reservations map
        //    return reservationMap.Values.ToList();
        //}

        //protected override Reservation ProcessRecord(Record record) {
        //    OrderDAO orderDAO = new OrderDAO();
        //    TableDAO tableDAO = new TableDAO();
        //    Table table = tableDAO.GetById((int) record["TableNumber"]);

        //    Customer customer = null;
        //    if (record["Customer"] != DBNull.Value) {
        //        CustomerDAO customerDAO = new CustomerDAO();
        //        customer = customerDAO.GetById((int) record["Customer"]);
        //    }

        //    int id = (int) record["ReservationId"];
        //return new Reservation() {
        //Id = id,
        //    Customer = customer,
        //    Table = table,
        //    Orders = orderDAO.GetByReservationId(id)
        //};
        //}
    }
}
