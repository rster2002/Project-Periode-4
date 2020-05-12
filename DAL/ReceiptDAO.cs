using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class ReceiptDAO : SQLInterface<Receipt> {

        public List<Receipt> GetAllReceipts() {

            line("SELECT *");
            line("FROM [RECEIPT]");

            return execute();
        }

        public Receipt GetReceiptById(int id) {

            line("SELECT *");
            line("FROM [RECEIPT]");
            line("WHERE ReceiptId = @id");

            param("id", id);

            return execute()[0];
        }

        protected override Receipt processRecord(Record record) {

            return new Receipt() {

                id = (int) record["ReceiptId"],
                //register
                //orders
            };
        }
    }
}
