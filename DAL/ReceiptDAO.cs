using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class ReceiptDAO : SQLInterface<Receipt> {
        private void BasicSelect() {
           
            Line("SELECT *");
            Line("FROM [Receipt]");

            Line("JOIN [Register] ON [Receipt].RegisterId = [Register].RegisterId");
            Line("JOIN [Order] ON [Receipt].ReceiptId = [Order].ReceiptId");
            Line("JOIN [Staff] ON [Order].OrderPlacedBy = [Staff].StaffNumber");
            Line("JOIN [OrderItem] ON [Order].OrderId = [OrderItem].OrderId");
            Line("JOIN [MenuItem] ON [OrderItem].MenuItemId = [MenuItem].MenuItemId");
        }

        public override List<Receipt> GetAll() {
           
            BasicSelect();

            return Execute();
        }

        public override Receipt GetById(int id) {
           
            BasicSelect();
            Line("WHERE ReceiptId = @id");

            Param("id", id);

            return Execute()[0];
        }

        public override List<Receipt> ProcessRecords(List<Record> records) {
            Dictionary<int, Receipt> receiptMap = new Dictionary<int, Receipt>();
            OrderDAO orderDAO = new OrderDAO();

            foreach (Record record in records) {
                int receiptId = (int) record["ReceiptId"];

                if (!receiptMap.ContainsKey(receiptId)) {
                    Receipt receipt = ProcessRecord(record);

                    // 'ProcessRecords' is always available, even when it's not overriden.
                    // In that case, it takes the records and parses them through 'ProcessRecord'
                    receipt.Orders = orderDAO.ProcessRecords(
                        records
                            .Where(r => (int) r["ReceiptId"] == receiptId)
                            .ToList()
                    );

                    receiptMap[receiptId] = receipt;
                }
            }

            return receiptMap.Values.ToList();
        }

        protected override Receipt ProcessRecord(Record record) {

            return new Receipt() {

                Id = (int) record["ReceiptId"],
                Register = new Register() {
                    Name = (string) record["RegisterName"],
                    Id = (int) record["RegisterId"],
                    CashBalance = (decimal) record["CashBalance"]
                }
            };
        }
    }
}
