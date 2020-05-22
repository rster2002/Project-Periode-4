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
            ReceiptDAO receiptDAO = new ReceiptDAO();

            List<Receipt> receipts = receiptDAO.GetAll();

            receipts.ForEach(receipt => {
                Console.WriteLine("{0}", receipt.Id);
            });

            Console.ReadKey();
        }
    }
}
