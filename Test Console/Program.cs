using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Diagnostics;

namespace Test_Console {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.Start();
        }

        void Start() {
            ReservationDAO reservationDAO = new ReservationDAO();
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Started cold");
            stopwatch.Start();

            reservationDAO.GetAll();

            stopwatch.Stop();
            Console.WriteLine("Completed cold: {0}", stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();

            Console.WriteLine("Started hot");
            stopwatch.Start();

            List<Reservation> reservations = reservationDAO.GetAll();

            stopwatch.Stop();
            Console.WriteLine("Completed hot: {0}", stopwatch.ElapsedMilliseconds);

            reservations.ForEach(reservation => {
                reservation.Orders.ForEach(order => {
                    order.MenuItems.ForEach(menuItem => {
                        Console.WriteLine("{0}: {1}: {2}", reservation.Id, order.Id, menuItem.Id);
                    });
                });
            });

            Console.ReadKey();
        }
    }
}
