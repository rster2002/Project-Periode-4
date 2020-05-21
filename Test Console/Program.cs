using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Logic;
using Model;
using System.Diagnostics;

namespace Test_Console {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.Start();
        }

        void Start() {
            OrderDAO orderDAO = new OrderDAO();
            Stopwatch stopwatch = new Stopwatch();

            orderDAO.DeleteByDateTimeRange(new DateTime(2020, 5, 1, 9, 0, 0), new DateTime(2020, 5, 1, 23, 0, 0));

            Console.ReadKey();
        }
    }
}
