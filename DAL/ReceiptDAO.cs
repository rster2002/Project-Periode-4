using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using System.Runtime.CompilerServices;

namespace DAL {
    public class ReceiptDAO : SQLInterface<Receipt> {
        private void BasicSelect() {
            Line("SELECT *");
            Line("FROM [Receipt]");

            Line("JOIN [Order] ON [Receipt].ReceiptId = [Order].ReceiptId");
            Line("JOIN [Staff] ON [Order].OrderPlacedBy = [Staff].StaffNumber");
            Line("JOIN [OrderItem] ON [Order].OrderId = [OrderItem].OrderId");
            Line("JOIN [MenuItem] ON [OrderItem].MenuItemId = [MenuItem].MenuItemId");
        }

        #region Create
        public void Insert(int id, string paymentMethod, object tip, object feedback) {
            Line("INSERT INTO [Receipt]");

            Param("id", id);
            Param("paymentMethod", paymentMethod);

            if (tip != null && feedback != null) {
                Line("VALUES (@id, @paymentMethod, @tip, @feedback)");

                Param("tip", (decimal) tip);
                Param("feedback", (string) feedback);
            } else if (tip != null) {
                Line("VALUES (@id, @paymentMethod, @tip, NULL)");

                Param("tip", (decimal) tip);
            } else if (feedback != null) {
                Line("VALUES (@id, @paymentMethod, NULL, @feedback)");

                Param("feedback", (string) feedback);
            } else {
                Line("VALUES (@id, @paymentMethod, NULL, NULL)");
            }

            Execute();
        }
        #endregion Create

        #region Read
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
        #endregion Read

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
            Receipt receipt = new Receipt() {
                Id = (int) record["ReceiptId"],
                Feedback = record["Feedback"] != DBNull.Value ? (string) record["Feedback"] : null,
            };

            if (record["Tip"] != DBNull.Value) {
                receipt.Tip = (decimal) record["Tip"];
            }

            return receipt;
        }
    }
}
