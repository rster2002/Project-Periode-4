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

            Console.WriteLine("Start");
            stopwatch.Start();

            reservationDAO.GetAll().ForEach(reservation => {
                reservation.Orders.ForEach(order => {
                    Console.WriteLine("{0}: {1}", reservation.Id, order.Id);
                });
            });

            stopwatch.Stop();
            Console.WriteLine("End first: {0}ms", stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
            stopwatch.Start();

            reservationDAO.GetAll().ForEach(reservation => {
                reservation.Orders.ForEach(order => {
                    Console.WriteLine("{0}: {1}", reservation.Id, order.Id);
                });
            });

            stopwatch.Stop();
            Console.WriteLine("End second: {0}ms", stopwatch.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }
}
