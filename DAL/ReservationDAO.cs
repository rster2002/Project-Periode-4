using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL {
    public class ReservationDAO:SQLInterface<Reservation> {
        public List<Reservation> getAll() {
            line("SELECT *, (");
                line("SELECT[Customer].CustomerSurname AS CustomerSurname");
                line("FROM[Customer]");
                line("WHERE[Reservation].Customer = [Customer].CustomerId");
            line(")");
            line("FROM[Reservation]");
            line("JOIN[Table] ON[Reservation].TableNumber = [Table].TableNumber");
            line("JOIN [Staff] ON [Table].ServedBy = [Staff].StaffNumber");
            line("JOIN [Order] ON [Reservation].ReservationId = [Order].ReservationId");

            return execute(processJoined);
        }

        protected List<Reservation> processJoined(List<Record> records) {
            Dictionary<int, Reservation> reservationMap = new Dictionary<int, Reservation>();

            foreach (Record record in records) {
                Reservation reservation = processRecord(record);

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

                    reservationMap[reservation.id] = reservation;
                }

                reservationMap[reservation.id].orders.Add(new Order() {
                    id = (int) record["OrderId"]
                });
            }

            return reservationMap.Values.ToList();
        }

        protected override Reservation processRecord(Record record) {
            return new Reservation() {
                id = (int) record["ReservationId"],
                customer = null,
                table = null
            };
        }
    }
}
