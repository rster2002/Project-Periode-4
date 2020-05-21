﻿using System;
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
            ReservationService reservationService = new ReservationService();
            Stopwatch stopwatch = new Stopwatch();

            reservationService.AddReservation(tableNumber: 2, customerId: null);

            Console.ReadKey();
        }
    }
}
