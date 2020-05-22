using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class ReceiptDAO : SQLInterface<Receipt> {

        public List<Receipt> GetAllReceipts() {

            Line("SELECT *");
            Line("FROM [RECEIPT]");

            return Execute();
        }

        public Receipt GetReceiptById(int id) {

            Line("SELECT *");
            Line("FROM [RECEIPT]");
            Line("WHERE ReceiptId = @id");

            Param("id", id);

            return Execute()[0];
        }

        protected override Receipt ProcessRecord(Record record) {

            return new Receipt() {

                Id = (int) record["ReceiptId"],
                //register
                //orders
            };
        }
    }
}
