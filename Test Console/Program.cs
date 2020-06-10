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
            TableDAO tableDAO = new TableDAO();
            OrderDAO orderDAO = new OrderDAO();
            MenuDAO menuDAO = new MenuDAO();

            //menuDAO.Insert(915, "Secret menu", new TimeSpan(10, 10, 10), new TimeSpan(10, 20, 20));

            List<Menu> menus = menuDAO.GetAll();

            Console.WriteLine(menus);
            Console.ReadKey();
        }
    }
}
