using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Model {
    public class OrderService {
        private OrderDAO orderDAO = new OrderDAO();

        #region Create
        public void AddOrder(int reservationId, DateTime placedAt, int placedBy) => orderDAO.Insert(reservationId, placedAt, placedBy);
        public void AddOrder(int reservationId, DateTime placedAt, int placedBy, int receiptId) => orderDAO.Insert(reservationId, placedAt, placedBy, receiptId);
        public void AddOrder(int reservationId, DateTime placedAt, int placedBy, string tag) => orderDAO.Insert(reservationId, placedAt, placedBy, tag);
        public void AddOrder(int reservationId, DateTime placedAt, int placedBy, int receiptId, string tag) => orderDAO.Insert(reservationId, placedAt, placedBy, receiptId, tag);
        public void AddOrder(int orderId, int reservationId, DateTime placedAt, int placedBy) => orderDAO.Insert(orderId, reservationId, placedAt, placedBy);
        public void AddOrder(int orderId, int reservationId, DateTime placedAt, int placedBy, int receiptId) => orderDAO.Insert(orderId, reservationId, placedAt, placedBy, receiptId);
        public void AddOrder(int orderId, int reservationId, DateTime placedAt, int placedBy, string tag) => orderDAO.Insert(orderId, reservationId, placedAt, placedBy, tag);
        public void AddOrder(int orderId, int reservationId, DateTime placedAt, int placedBy, int receiptId, string tag) => orderDAO.Insert(orderId, reservationId, placedAt, placedBy, receiptId, tag);
        #endregion Create

        #region Read
        public List<Order> GetAllOrders() => orderDAO.GetAll();
        public Order GetOrderById(int id) => orderDAO.GetById(id);
        public List<Order> GetOrdersByReservationId(int reservationId) => orderDAO.GetByReservationId(reservationId);
        public List<Order> GetOrdersByReceiptId(int receiptId) => orderDAO.GetByReceiptId(receiptId);
        public List<Order> GetOrdersByDateTimeRange(DateTime startDateTime, DateTime endDateTime) => orderDAO.GetByDateTimeRange(startDateTime, endDateTime);
        public List<Order> GetOrderByTableId(int tableNumber) => orderDAO.GetByTableNumber(tableNumber);
        public List<Order> GetAllOrdersWithDrinks() => orderDAO.GetAllOrdersContainingDrinks();
        public List<Order> GetAllOrdersContainingDishes() => orderDAO.GetAllOrdersContainingDishes();
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
