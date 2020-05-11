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

                if (!reservationMap.ContainsKey(reservation.id)) {
                    reservation.orders = new List<Order>();
                    reservation.table = new Table() {
                        number = (int) record["TableNumber"],
                        numberOfSeats = (int) record["TableSeats"],
                        servedBy = new Staff() {
                            id = (int) record["StaffNumber"],
                            name = (string) record["StaffName"],
                            salt = (int) record["StaffSalt"],
                            role = (string) record["StaffRole"]
                        }
                    };

                    if (record["Customer"] != DBNull.Value) {
                        reservation.customer = new Customer() {
                            id = (int) record["Customer"],
                            name = (string) record["CustomerSurname"]
                        };
                    }

                    reservationMap[reservation.id] = reservation;
                }

                reservationMap[reservation.id].orders.Add(new Order() {
                    id = (int) record["OrderId"]
                });
            }

            return reservationMap.Values.ToList();
        }

        protected override Reservation ProcessRecord(Record record) {
            return new Reservation() {
                id = (int) record["ReservationId"],
                customer = null,
                table = null
            };
        }
    }
}
