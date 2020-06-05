using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Model {
    public class OrderService {
        private Random random = new Random();
        private OrderDAO orderDAO = new OrderDAO();
        private ReservationService reservationService = new ReservationService();
        private UserSession userSession = UserSession.GetInstance();

        #region Create
        public void AddOrder(int reservationId, Order order) => AddOrder(order.Id, reservationId, order.PlacedAt, order.PlacedBy.Id, order.Tag);
        public void AddOrder(int orderId, int reservationId, DateTime placedAt, int placedBy) => orderDAO.Insert(orderId, reservationId, placedAt, placedBy);
        public void AddOrder(int orderId, int reservationId, DateTime placedAt, int placedBy, int receiptId) => orderDAO.Insert(orderId, reservationId, placedAt, placedBy, receiptId);
        public void AddOrder(int orderId, int reservationId, DateTime placedAt, int placedBy, string tag) => orderDAO.Insert(orderId, reservationId, placedAt, placedBy, tag);
        public void AddOrder(int orderId, int reservationId, DateTime placedAt, int placedBy, int receiptId, string tag) => orderDAO.Insert(orderId, reservationId, placedAt, placedBy, receiptId, tag);
        public void AddOrderItems(Order order, List<MenuItem> menuItems) => orderDAO.InsertMenuItems(order, menuItems);

        public void PlaceOrder(Table table, List<MenuItem> menuItems, bool splitOrder = false) {
            Reservation reservation = reservationService.GetReservationByTableNumber(table.Number);
            Order baseOrder = new Order() {
                PlacedAt = DateTime.Now,
                PlacedBy = userSession.LoggedInStaff,
                MenuItems = menuItems,
            };

            if (reservation == null) {
                int reservationId = random.Next(0, 999999);
                reservationService.AddReservation(reservationId, table.Number);

                reservation = new Reservation() {
                    Id = reservationId
                };
            } else if (reservation.Customer != null) {
                reservationService.UpdateCustomer(reservation.Id, null);
            }

            if (splitOrder) {
                List<string> subtypes = new List<string>();

                foreach (MenuItem menuItem in menuItems) {
                    if (!subtypes.Contains(menuItem.Subtype) && menuItem.Type == "food") {
                        Order subtypeOrder = GenerateOrderForSubtype(baseOrder, menuItem.Subtype);

                        AddOrder(reservation.Id, subtypeOrder);
                        AddOrderItems(subtypeOrder, subtypeOrder.MenuItems);
                    }
                }

                List<MenuItem> drinks = menuItems
                    .Where(item => item.Type == "drink")
                    .ToList();

                if (drinks.Count > 0) {
                    Order drinksOrder = GenerateOrderForType(baseOrder, "drink");

                    AddOrder(reservation.Id, drinksOrder);
                    AddOrderItems(drinksOrder, drinksOrder.MenuItems);
                }
            } else {
                baseOrder.Id = random.Next(0, 999999);

                AddOrder(baseOrder.Id, reservation.Id, baseOrder.PlacedAt, baseOrder.PlacedBy.Id);
                AddOrderItems(baseOrder, menuItems);
            }
        }

        private Order GenerateOrderForSubtype(Order baseOrder, string subtype) {
            return new Order() {
                Id = random.Next(0, 999999),
                PlacedAt = baseOrder.PlacedAt,
                PlacedBy = baseOrder.PlacedBy,
                Tag = subtype,
                MenuItems = baseOrder
                    .MenuItems
                    .Where(item => item.Subtype == subtype)
                    .ToList()
            };
        }

        private Order GenerateOrderForType(Order baseOrder, string type) {
            return new Order() {
                Id = random.Next(0, 999999),
                PlacedAt = baseOrder.PlacedAt,
                PlacedBy = baseOrder.PlacedBy,
                Tag = type,
                MenuItems = baseOrder
                    .MenuItems
                    .Where(item => item.Type == type)
                    .ToList()
            };
        }
        #endregion Create

        #region Read
        public List<Order> GetAllOrders() => orderDAO.GetAll();
        public Order GetOrderById(int id) => orderDAO.GetById(id);
        public List<Order> GetOrdersByReservationId(int reservationId) => orderDAO.GetByReservationId(reservationId);
        public List<Order> GetOrdersByReceiptId(int receiptId) => orderDAO.GetByReceiptId(receiptId);
        public List<Order> GetOrdersByDateTimeRange(DateTime startDateTime, DateTime endDateTime) => orderDAO.GetByDateTimeRange(startDateTime, endDateTime);
        public List<Order> GetOrderByTableId(int tableNumber) => orderDAO.GetByTableNumber(tableNumber);
        #endregion Read

        #region Update
        public void Update(int id, int reservationId, DateTime placedAt, int placedBy, int receiptId, object tag) => orderDAO.UpdateById(id, reservationId, placedAt, placedBy, receiptId, tag);
        public void UpdateReservationId(int id, int reservationId) => orderDAO.UpdateReservationId(id, reservationId);
        public void UpdatePlacedBy(int id, int placedBy) => orderDAO.UpdatePlacedBy(id, placedBy);
        public void UpdateReceiptId(int id, object receiptId) => orderDAO.UpdateReceiptId(id, receiptId);
        public void UpdateTag(int id, object tag) => orderDAO.UpdateTag(id, tag);
        #endregion Update

        #region Delete
        public void DeleteById(int id) => orderDAO.DeleteById(id);
        public void DeleteByReservationId(int reservationId) => orderDAO.DeleteByReservationId(reservationId);
        public void DeleteByReceiptId(int receiptId) => orderDAO.DeleteByReceiptId(receiptId);
        public void DeleteByDateTimeRange(DateTime startDateTime, DateTime endDateTime) => orderDAO.DeleteByDateTimeRange(startDateTime, endDateTime);
        #endregion Delete
    }
}
