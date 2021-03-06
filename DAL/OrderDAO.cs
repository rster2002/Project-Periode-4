﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL {
    public class OrderDAO: SQLInterface<Order> {
        private void BasicSelect() {
            Line("SELECT *");
            Line("FROM [Order]");
            Line("OUTER APPLY (");
                Line("SELECT *");
                Line("FROM [Staff]");
                Line("WHERE [StaffNumber] = [OrderPlacedBy]");
            Line(") AS StaffSelect");
            Line("JOIN [OrderItem] ON [Order].OrderId = [OrderItem].OrderId");
            Line("JOIN [MenuItem] ON [OrderItem].MenuItemId = [MenuItem].MenuItemId");
        }

        #region Create
        public void Insert(int orderId, int reservationId, DateTime placedAt, int placedBy) {
            Line("INSERT INTO [Order]");
            Line("VALUES (@orderId, @reservationId, @placedAt, @placedBy, NULL, NULL, 'open')");

            Param("orderId", orderId);
            Param("reservationId", reservationId);
            Param("placedAt", placedAt);
            Param("placedBy", placedBy);

            Execute();
        }

        public void Insert(int orderId, int reservationId, DateTime placedAt, int placedBy, int receiptId) {
            Line("INSERT INTO [Order]");
            Line("VALUES (@orderId, @reservationId, @placedAt, @placedBy, @receiptId, NULL, 'open')");

            Param("orderId", orderId);
            Param("reservationId", reservationId);
            Param("placedAt", placedAt);
            Param("placedBy", placedBy);
            Param("receiptId", receiptId);

            Execute();
        }

        public void Insert(int orderId, int reservationId, DateTime placedAt, int placedBy, string tag) {
            Line("INSERT INTO [Order]");
            Line("VALUES (@orderId, @reservationId, @placedAt, @placedBy, NULL, @tag, 'open')");

            Param("orderId", orderId);
            Param("reservationId", reservationId);
            Param("placedAt", placedAt);
            Param("placedBy", placedBy);
            Param("tag", tag);

            Execute();
        }

        public void Insert(int orderId, int reservationId, DateTime placedAt, int placedBy, int receiptId, string tag) {
            Line("INSERT INTO [Order]");
            Line("VALUES (@orderId, @reservationId, @placedAt, @placedBy, @receiptId, @tag, 'open')");

            Param("orderId", orderId);
            Param("reservationId", reservationId);
            Param("placedAt", placedAt);
            Param("placedBy", placedBy);
            Param("receiptId", receiptId);
            Param("tag", tag);

            Execute();
        }

        // Placed in this DAO because 'OrderItem' does not have it's own DAO
        public void InsertMenuItems(Order order, List<MenuItem> menuItems) {
            List<string> values = new List<string>();

            for (int i = 0; i < menuItems.Count; i++) {
                MenuItem item = menuItems[i];

                Param("menuItemId" + i, item.Id);

                string valueString;
                if (item.Comment != null) {
                    Param("comment" + i, item.Comment);
                    valueString = $"(@orderId, @menuItemId{i}, @comment{i})";
                } else {
                    valueString = $"(@orderId, @menuItemId{i}, NULL)";
                }

                for (int j = 0; j < item.Amount; j++) {
                    values.Add(valueString);
                }
            }

            Param("orderId", order.Id);

            Line("INSERT INTO [OrderItem]");
            Line($"VALUES {String.Join(", ", values)}");

            Execute();
        }
        #endregion Create

        #region Read
        public override List<Order> GetAll() {
            BasicSelect();
            Line("ORDER BY [OrderPlacedDateTime] ASC");

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
            Line("ORDER BY [OrderPlacedDateTime] ASC");

            Param("reservationId", reservationId);

            return Execute();
        }

        public List<Order> GetByReceiptId(int receiptId) {
            BasicSelect();
            Line("WHERE [ReceiptId] = @receiptId");
            Line("ORDER BY [OrderPlacedDateTime] ASC");

            Param("receiptId", receiptId);

            return Execute();
        }

        public List<Order> GetByDateTimeRange(DateTime startDateTime, DateTime endDateTime) {
            BasicSelect();
            Line("WHERE [OrderPlacedDateTime] > @startDateTime AND [OrderPlacedDateTime] < @endDateTime");
            Line("ORDER BY [OrderPlacedDateTime] ASC");

            Param("startDateTime", startDateTime);
            Param("endDateTime", endDateTime);

            return Execute();
        }

        public List<Order> GetByTableNumber(int tableNumber) {
            BasicSelect();
            Line("JOIN [Reservation] ON [Order].ReservationId = [Reservation].ReservationId");
            Line("WHERE [TableNumber] = @tableNumber");
            Line("ORDER BY [OrderPlacedDateTime] ASC");

            Param("tableNumber", tableNumber);

            return Execute();
        }

        public List<Order> GetAllOrdersContainingDrinks() {
            BasicSelect();
            Line("WHERE [Type] = 'drink'");

            return Execute();
        }

        public List<Order> GetAllOrdersContainingDishes() {
            BasicSelect();
            Line("WHERE [Type] = 'food'");

            return Execute();
        }

        public List<Order> GetOpenOrders() {
            BasicSelect();
            Line("WHERE [Status] = 'open'");

            return Execute();
        }

        public bool GetPreparedOrdersByTableId(int id) {
            Query("SELECT * FROM[Order]  " +
                    "JOIN[Reservation] ON[Order].ReservationId = [Reservation].ReservationId    " +
                    " WHERE[Reservation].TableNumber = @id AND[Status] = 'prepared';");

            Param("id", id);

            List<Record> records = ExecuteUnprocessed();
            return records.Count > 0;
        }
        public List<Order> GetListPreparedOrdersByTableId(int id) {
            BasicSelect();
            Line("JOIN[Reservation] ON[Order].ReservationId = [Reservation].ReservationId");
            Line("WHERE[Reservation].TableNumber = @id AND[Status] = 'prepared'");

            Param("id", id);

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
                Param("reservationId", (int) reservationId);
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
                Line("SET [ReceiptId] = @receiptId");
                Param("receiptId", (int) receiptId);
            } else {
                Line("SET [ReceiptId] = NULL");
            }

            Line("WHERE [OrderId] = @id");

            Param("id", id);

            Execute();
        }
        
        public void UpdateReceiptIdByReservationId(int reservationId, object receiptId) {
            Line("UPDATE [Order]");

            if (receiptId != null) {
                Line("SET [ReceiptId] = @receiptId");
                Param("receiptId", (int) receiptId);
            } else {
                Line("SET [ReceiptId] = NULL");
            }

            Line("WHERE [ReservationId] = @reservationId");

            Param("reservationId", reservationId);

            Execute();
        }

        public void UpdateReservationIdByReservationId(int reservationId, object newReservationId) {
            Line("UPDATE [Order]");

            if (newReservationId != null) {
                Line("SET [ReservationId] = @newReservationId");
                Param("newReservationId", (int) newReservationId);
            } else {
                Line("SET [ReservationId] = NULL");
            }

            Line("WHERE [ReservationId] = @reservationId");

            Param("reservationId", reservationId);

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
        
        public void CloseOrder(int id) {
            Line("UPDATE [Order]");
            Line("SET [Status] = 'closed'");
            Line("WHERE [OrderId] = @id");

            Param("id", id);

            Execute();
        }
        public void OpenOrder(int id) {
            Line("UPDATE [Order]");
            Line("SET [Status] = 'open'");
            Line("WHERE [OrderId] = @id");

            Param("id", id);

            Execute();
        }

        public void PrepareOrder(int id) {
            Line("UPDATE [Order]");
            Line("SET [Status] = 'prepared'");
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

        protected override Order ProcessRecord(Record record) {
            Staff staff = null;

            if (record["StaffNumber"] != DBNull.Value) {
                staff = new Staff() {
                    Id = (int) record["StaffNumber"],
                    Name = (string) record["StaffName"],
                    Salt = (int) record["StaffSalt"],
                    Role = (string) record["StaffRole"]
                };
            }

            Order order = new Order() {
                Id = (int) record["OrderId"],
                PlacedBy = staff,
                PlacedAt = (DateTime) record["OrderPlacedDateTime"],
                Tag = null,
                Status = (string) record["Status"],
            };
            if (record.ContainsKey("Tag")) {
                order.Tag = record["Tag"] != DBNull.Value ? (string) record["Tag"] : null;
            }
            return order;
        }
    }
}
