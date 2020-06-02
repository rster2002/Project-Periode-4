using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

        #region Create
        public void Insert(int tableNumber, object customerId) {
            Line("INSERT INTO [Reservation]");

            if (customerId != null) {
                Line("VALUES (@tableNumber, @customerId)");
                Param("customerId", customerId);
            } else {
                Line("VALUES (@tableNumber, NULL)");
            }

            Param("tableNumber", tableNumber);

            Execute();
        }

        public void Insert(int reservationId, int tableNumber, object customerId) {
            Line("INSERT INTO [Reservation]");

            if (customerId != null) {
                Line("VALUES (@reservationId, @tableNumber, @customerId)");
                Param("customerId", customerId);
            } else {
                Line("VALUES (@reservationId, @tableNumber, NULL)");
            }

            Param("reservationId", reservationId);
            Param("tableNumber", tableNumber);

            Execute();
        }
        #endregion Create

        #region Read
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

        public List<Reservation> GetByCustomerId(int id) {
            BasicSelect();
            Line("WHERE [Customer] = @id");

            Param("id", id);

            return Execute();
        }

        public Reservation GetByTableNumber(int number) {
            BasicSelect();
            Line("WHERE [Table].[TableNumber] = @number");

            Param("number", number);

            List<Reservation> reservations = Execute();
            return reservations.Count >= 1 ? reservations[0] : null;
        }
        #endregion Read

        #region Update
        public void UpdateById(int id, int tableNumber, object customerId) {
            Line("UPDATE [Reservation]");
            Line("SET [TableNumber] = @tableNumber");

            if (customerId != null) {
                Line("SET [Customer] = @customerId");
                Param("customerId", customerId);
            } else {
                Line("SET [Customer] = NULL");
            }

            Line("WHERE [ReservationId] = @id");

            Param("tableNumber", tableNumber);
            Param("id", id);

            Execute();
        }

        public void UpdateTableNumberById(int id, int tableNumber) {
            Line("UPDATE [Reservation]");
            Line("SET [TableNumber] = @tableNumber");
            Line("WHERE [ReservationId] = @id");

            Param("tableNumber", tableNumber);
            Param("id", id);

            Execute();
        }

        public void UpdateCustomerById(int id, object customerId) {
            Line("UPDATE [Reservation]");

            if (customerId != null) {
                Line("SET [Customer] = @customerId");
                Param("customerId", customerId);
            } else {
                Line("SET [Customer] = NULL");
            }

            Line("WHERE [ReservationId] = @id");

            Param("id", id);

            Execute();
        }
        #endregion Update

        #region Delete
        public void DeleteById(int id) {
            Line("DELETE [Reservation]");
            Line("WHERE [ReservationId] = @id");

            Param("id", id);

            Execute();
        }

        public void DeleteByTableNumber(int tableNumber) {
            Line("DELETE [Reservation]");
            Line("WHERE [TableNumber] = @tableNumber");

            Param("tableNumber", tableNumber);

            Execute();
        }

        public void DeleteByCustomerId(int customerId) {
            Line("DELETE [Reservation]");
            Line("WHERE [Customer] = @customerId");

            Param("customerId", customerId);

            Execute();
        }
        #endregion Delete

        protected override Reservation ProcessRecord(Record record)
        {
            return new Reservation()
            {
                Id = (int)record["ReservationId"],
                Customer = null,
                Table = new Table()
                {
                    Number = (int)record["TableNumber"],
                    NumberOfSeats = (int)record["TableSeats"],
                    ServedBy = new Staff()
                    {
                        Id = (int)record["StaffNumber"],
                        Name = (string)record["StaffName"],
                        Salt = (int)record["StaffSalt"],
                        Role = (string)record["StaffRole"]
                    }
                }
            };
        }

        public override List<Reservation> ProcessRecords(List<Record> records) {
            Dictionary<int, Reservation> reservationMap = new Dictionary<int, Reservation>();
            OrderDAO orderDAO = new OrderDAO();

            foreach (Record record in records) {
                int reservationId = (int) record["ReservationId"];

                // Check whether or not reservation has been processed yet
                if (!reservationMap.ContainsKey(reservationId)) {
                    Reservation reservation = ProcessRecord(record);

                    // Don't mind this
                    if (record["Customer"] != DBNull.Value) {
                        reservation.Customer = new Customer() {
                            Id = (int) record["Customer"],
                            Name = (string) record["CustomerSurname"]
                        };
                    }

                    // Because 'ProcessRecords' is public, we can ask other DAO's to process certain records for us
                    reservation.Orders = orderDAO.ProcessRecords(
                        // We only want to process the records that apply to the current reservation, so we filter out any that don't
                        // match the current reservation id
                        records
                            .Where(r => (int) r["ReservationId"] == reservationId)
                            .ToList()
                    );

                    reservationMap[reservationId] = reservation;
                }
            }

            return reservationMap.Values.ToList();
        }
    }
}
