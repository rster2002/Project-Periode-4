using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logic {
    public class ReceiptService {
        ReceiptDAO receiptDAO = new ReceiptDAO();

        public List<Receipt> GetAllReceipts() => receiptDAO.GetAll();
        public Receipt GetReceiptById(int id) => receiptDAO.GetById(id);
    }
}
