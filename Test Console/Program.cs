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

            reservationDAO.Insert(new Reservation() {
                Table = new Table() {
                    Number = 10,
                },
                Customer = new Customer() {
                    Id = 10,
                    Name = "Someone"
                }
            });

            Console.ReadKey();
        }
    }
}
