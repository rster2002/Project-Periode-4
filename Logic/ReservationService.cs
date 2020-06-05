using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Model {
    public class ReservationService {
        ReservationDAO reservationDAO = new ReservationDAO();

        public void AddReservation(int tableNumber) => reservationDAO.Insert(tableNumber, null);
        public void AddReservation(int tableNumber, object customerId) => reservationDAO.Insert(tableNumber, customerId);
        public void AddReservation(int reservationId, int tableNumber) => reservationDAO.Insert(reservationId, tableNumber, null);
        public void AddReservation(int reservationId, int tableNumber, object customerId) => reservationDAO.Insert(reservationId, tableNumber, customerId);

        public List<Reservation> GetAllReservations() => reservationDAO.GetAll();
        public Reservation GetReservationById(int id) => reservationDAO.GetById(id);
        public List<Reservation> GetReservationByCustomerId(int id) => reservationDAO.GetByCustomerId(id);
        public Reservation GetReservationByTableNumber(int number) => reservationDAO.GetByTableNumber(number);

        public void Update(int id, int tableNumber, object customerId) => reservationDAO.UpdateById(id, tableNumber, customerId);
        public void UpdateCustomer(int id, object customerId) => reservationDAO.UpdateCustomerById(id, customerId);
        public void UpdateTable(int id, int tableNumber) => reservationDAO.UpdateTableNumberById(id, tableNumber);

        public void DeleteById(int id) => reservationDAO.DeleteById(id);
        public void DeleteByTableNumber(int tableNumber) => reservationDAO.DeleteByTableNumber(tableNumber);
        public void DeleteByCustomerId(int customerId) => reservationDAO.DeleteByCustomerId(customerId);
    }
}
