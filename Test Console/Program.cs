using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Test_Console {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            ReservationDAO reservationDAO = new ReservationDAO();

            reservationDAO.getAll().ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
