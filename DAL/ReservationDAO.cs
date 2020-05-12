using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL {
    public class ReservationDAO:SQLInterface<Reservation> {
        private void basicSelect() {
            Line("SELECT *, (");
                Line("SELECT[Customer].CustomerSurname AS CustomerSurname");
                Line("FROM[Customer]");
                Line("WHERE[Reservation].Customer = [Customer].CustomerId");
            Line(") AS CustomerSurname");
            Line("FROM[Reservation]");
            Line("JOIN[Table] ON[Reservation].TableNumber = [Table].TableNumber");
            Line("JOIN [Staff] ON [Table].ServedBy = [Staff].StaffNumber");
            Line("JOIN [Order] ON [Reservation].ReservationId = [Order].ReservationId");
        }

        public List<Reservation> getAll() {
            basicSelect();

            return Execute(processJoined);
        }

        public Reservation getById(int id) {
            basicSelect();
            Line("WHERE [ReservationId] = @id");

            Param("id", id);

            return Execute(processJoined)[0];
        }

        protected List<Reservation> processJoined(List<Record> records) {
            Dictionary<int, Reservation> reservationMap = new Dictionary<int, Reservation>();

            foreach (Record record in records) {
                Reservation reservation = ProcessRecord(record);

                if (!reservationMap.ContainsKey(reservation.Id)) {
                    reservation.Orders = new List<Order>();
                    reservation.Table = new Table() {
                        Number = (int) record["TableNumber"],
                        NumberOfSeats = (int) record["TableSeats"],
                        ServedBy = new Staff() {
                            Id = (int) record["StaffNumber"],
                            Name = (string) record["StaffName"],
                            Salt = (int) record["StaffSalt"],
                            Role = (string) record["StaffRole"]
                        }
                    };

                    if (record["Customer"] != DBNull.Value) {
                        reservation.Customer = new Customer() {
                            Id = (int) record["Customer"],
                            Name = (string) record["CustomerSurname"]
                        };
                    }

                    reservationMap[reservation.Id] = reservation;
                }

                reservationMap[reservation.Id].Orders.Add(new Order() {
                    Id = (int) record["OrderId"]
                });
            }

            return reservationMap.Values.ToList();
        }

        protected override Reservation ProcessRecord(Record record) {
            return new Reservation() {
                Id = (int) record["ReservationId"],
                Customer = null,
                Table = null
            };
        }
    }
}
