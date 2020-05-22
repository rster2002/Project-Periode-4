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
            program.Start();
        }

        void Start() {
            OrderDAO OrderDAO = new OrderDAO();

            Console.WriteLine("{0}", OrderDAO.GetById(3).Id);
            

            Console.ReadKey();
        }
    }
}
