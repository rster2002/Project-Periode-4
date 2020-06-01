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
            OrderDAO orderDAO = new OrderDAO();

            //orderDAO.GetByTableNumber(4).ForEach(order => {
            //    order.MenuItems.ForEach(menuItem => {
            //        Console.WriteLine("{0}: {1}", order.Id, menuItem.Name);
            //    });
            //});

            Console.ReadKey();
        }
    }
}
