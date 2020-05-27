﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
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

        #region Create
        public void Insert(int reservationId, DateTime placedAt, int placedBy) {
            Line("INSERT INTO [Order]");
            Line("VALUES (@reservationId, @placedAt, @placedBy, NULL, NULL)");

            Param("reservationId", reservationId);
            Param("placedAt", placedAt);
            Param("placedBy", placedBy);

            Execute();
        }

        public void Insert(int reservationId, DateTime placedAt, int placedBy, int receiptId) {
            Line("INSERT INTO [Order]");
            Line("VALUES (@reservationId, @placedAt, @placedBy, @receiptId, NULL)");

            Param("reservationId", reservationId);
            Param("placedAt", placedAt);
            Param("placedBy", placedBy);
            Param("receiptId", receiptId);

            Execute();
        }

        public void Insert(int reservationId, DateTime placedAt, int placedBy, string tag) {
            Line("INSERT INTO [Order]");
            Line("VALUES (@reservationId, @placedAt, @placedBy, NULL, @tag)");

            Param("reservationId", reservationId);
            Param("placedAt", placedAt);
            Param("placedBy", placedBy);
            Param("tag", tag);

            Execute();
        }

        public void Insert(int reservationId, DateTime placedAt, int placedBy, int receiptId, string tag) {
            Line("INSERT INTO [Order]");
            Line("VALUES (@reservationId, @placedAt, @placedBy, @receiptId, @tag)");

            Param("reservationId", reservationId);
            Param("placedAt", placedAt);
            Param("placedBy", placedBy);
            Param("receiptId", receiptId);
            Param("tag", tag);

            Execute();
        }
        #endregion Create

        #region Read
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

        public List<Order> GetByReservationId(int reservationId) {
            BasicSelect();
            Line("WHERE [ReservationId] = @reservationId");

            Param("reservationId", reservationId);

            return Execute();
        }

        public List<Order> GetByReceiptId(int receiptId) {
            BasicSelect();
            Line("WHERE [ReceiptId] = @receiptId");

            Param("receiptId", receiptId);

            return Execute();
        }

        public List<Order> GetByDateTimeRange(DateTime startDateTime, DateTime endDateTime) {
            BasicSelect();
            Line("WHERE [OrderPlacedDateTime] > @startDateTime AND [OrderPlacedDateTime] < @endDateTime");

            Param("startDateTime", startDateTime);
            Param("endDateTime", endDateTime);

            return Execute();
        }

        public List<Order> GetByTableNumber(int tableNumber) {
            BasicSelect();
            Line("JOIN [Reservation] ON [Order].ReservationId = [Reservation].ReservationId");
            Line("WHERE [TableNumber] = @tableNumber");

            Param("tableNumber", tableNumber);

            return Execute();
        }
        #endregion Read

        #region Update
        public void UpdateById(int id, int reservationId, DateTime placedAt, int placedBy, int receiptId, object tag) {
            Line("UPDATE [Order]");
            Line("SET [ReservationId] = @reservationId");
            Line("SET [OrderPlacedDateTime] = @placedAt");
            Line("SET [PlacedBy] = @placedBy");
            Line("SET [receiptId] = @receiptId");

            if (tag != null) {
                Line("SET [Tag] = @tag");
                Param("tag", tag);
            } else {
                Line("SET [Tag] = NULL");
            }

            Line("WHERE [OrderId] = @id");

            Param("id", id);
            Param("reservationId", reservationId);
            Param("placedBy", placedBy);
            Param("receiptId", receiptId);

            Execute();
        }

        public void UpdateReservationId(int id, object reservationId) {
            Line("UPDATE [Order]");

            if (reservationId != null) {
                Line("SET [ReservationId] = @reservationId");
                Param("reservationId", reservationId);
            } else {
                Line("SET [ReservationId] = NULL");
            }
            
            Line("WHERE [OrderId] = @id");

            Param("id", id);

            Execute();
        }

        public void UpdatePlacedAt(int id, DateTime placedAt) {
            Line("UPDATE [Order]");
            Line("SET [OrderPlacedDateTime] = @placedAt");
            Line("WHERE [OrderId] = @id");

            Param("id", id);
            Param("placedAt", placedAt);

            Execute();
        }

        public void UpdatePlacedBy(int id, int placedBy) {
            Line("UPDATE [Order]");
            Line("SET [PlacedBy] = @placedBy");
            Line("WHERE [OrderId] = @id");

            Param("id", id);
            Param("placedBy", placedBy);

            Execute();
        }

        public void UpdateReceiptId(int id, object receiptId) {
            Line("UPDATE [Order]");

            if (receiptId != null) {
                Line("SET [PlacedBy] = @placedBy");
                Param("receiptId", receiptId);
            } else {
                Line("SET [PlacedBy] = NULL");
            }

            Line("WHERE [OrderId] = @id");

            Param("id", id);

            Execute();
        }

        public void UpdateTag(int id, object tag) {
            Line("UPDATE [Order]");

            if (tag != null) {
                Line("SET [Tag] = @tag");
                Param("tag", tag);
            } else {
                Line("SET [Tag] = NULL");
            }

            Line("WHERE [OrderId] = @id");

            Param("id", id);

            Execute();
        }
        #endregion Update

        #region Delete
        public void DeleteById(int id) {
            Line("DELETE [Order]");
            Line("WHERE [OrderId] = @id");

            Param("id", id);

            Execute();
        }

        public void DeleteByReservationId(int reservationId) {
            Line("DELETE [Order]");
            Line("WHERE [ReservationId] = @reservationId");

            Param("reservationId", reservationId);

            Execute();
        }

        public void DeleteByDateTimeRange(DateTime startDateTime, DateTime endDateTime) {
            Line("DELETE [Order]");
            Line("WHERE [OrderPlacedDateTime] > @startDateTime AND [OrderPlacedDateTime] < @endDateTime");

            Param("startDateTime", startDateTime);
            Param("endDateTime", endDateTime);

            Execute();
        }

        public void DeleteByReceiptId(int receiptId) {
            Line("DELETE [Order]");
            Line("WHERE [ReceiptId] = @receiptId");

            Param("receiptId", receiptId);

            Execute();
        }
        #endregion Delete

        public override List<Order> ProcessRecords(List<Record> records) {
            Dictionary<int, Order> ordersMap = new Dictionary<int, Order>();
            MenuItemDAO menuItemDAO = new MenuItemDAO();

            foreach (Record record in records) {
                int orderId = (int) record["OrderId"];

                if (!ordersMap.ContainsKey(orderId)) {
                    Order order = ProcessRecord(record);

                    // 'ProcessRecords' is always available, even when it's not overriden.
                    // In that case, it takes the records and parses them through 'ProcessRecord'
                    order.MenuItems = menuItemDAO.ProcessRecords(
                        records
                            .Where(r => (int) r["OrderId"] == orderId)
                            .ToList()
                    );

                    ordersMap[orderId] = order;
                }
            }

            return ordersMap.Values.ToList();
        }

        //public override List<Order> ProcessRecords(List<Record> records) {
        //    Dictionary<int, Order> ordersMap = new Dictionary<int, Order>();

        //    foreach (Record record in records) {
        //        int orderId = (int) record["OrderId"];

        //        if (!ordersMap.ContainsKey(orderId)) {
        //            ordersMap[orderId] = ProcessRecord(record);
        //        }

        //        ordersMap[orderId].MenuItems.Add(new MenuItem() {
        //            Id = (int) record["MenuItemId"],
        //            Name = (string) record["MenuItemName"],
        //            Price = (decimal) record["Price"],
        //            VAT = (int) record["VAT"],
        //            AmountInStock = (int) record["InStock"],
        //            Comment = (string) record["Comment"]
        //        });
        //    }

        //    return ordersMap.Values.ToList();
        //}

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
