using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logic {
    class ReservationService {
        private ReservationDAO DAO = new ReservationDAO();

        public List<Reservation> GetAllReservations() => DAO.GetAll();
        public Reservation GetReservationById(int id) => DAO.GetById(id);
    }
}
