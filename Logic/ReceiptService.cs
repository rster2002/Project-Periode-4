using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Model {
    public class ReceiptService {
        ReceiptDAO receiptDAO = new ReceiptDAO();

        public List<Receipt> GetAllReceipts() => receiptDAO.GetAll();
        public Receipt GetReceiptById(int id) => receiptDAO.GetById(id);
        public void AddReceipt(int id, string paymentMethod) => receiptDAO.Insert(id, paymentMethod, null, null);
        public void AddReceipt(int id, string paymentMethod, decimal tip) => receiptDAO.Insert(id, paymentMethod, tip, null);
        public void AddReceipt(int id, string paymentMethod, string feedback) => receiptDAO.Insert(id, paymentMethod, null, feedback);
        public void AddReceipt(int id, string paymentMethod, decimal tip, string feedback) => receiptDAO.Insert(id, paymentMethod, tip, feedback);
        public void AddReceipt(int id, string paymentMethod, object tip, object feedback) => receiptDAO.Insert(id, paymentMethod, tip, feedback);
    }
}
