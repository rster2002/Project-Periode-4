using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Test_Console {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.Start();
        }

        void Start() {
            ReservationDAO reservationDAO = new ReservationDAO();

            reservationDAO.GetAll().ForEach(reservation => {
                reservation.Orders.ForEach(order => {
                    Console.WriteLine("{0}: {1}", reservation.Id, order.Id);
                });
            });

            Console.ReadKey();
        }
    }
}
