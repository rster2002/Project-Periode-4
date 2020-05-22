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
            ReservationDAO reservationDAO = new ReservationDAO();
            OrderDAO orderDAO = new OrderDAO();
            Stopwatch stopwatch = new Stopwatch();

            //orderDAO.GetAll().ForEach(order => {
            //    order.MenuItems.ForEach(menuItem => {
            //        Console.WriteLine("{0}: {1}", order.Id, menuItem.Id);
            //    });
            //});

            //reservationDAO.GetAll().ForEach(reservation => {
            //    reservation.Orders.ForEach(order => {
            //        order.MenuItems.ForEach(menuItem => {
            //            Console.WriteLine("{0}: {1}: {2}", reservation.Id, order.Id, menuItem.Id);
            //        });
            //    });
            //});

            MenuDAO menuDAO = new MenuDAO();
            menuDAO.GetAll().ForEach(menu => {
                menu.Items.ForEach(menuItem => {
                    Console.WriteLine("{0}: {1}", menu.Id, menuItem.Name);
                });
            });

            Console.ReadKey();
        }
    }
}
