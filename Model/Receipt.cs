using System.Collections.Generic;

namespace Model {
    public class Receipt {
        public int Id { get; set; }
        public decimal Tip { get; set; }
        public string Feedback { get; set; }
        public List<Order> Orders { get; set; }
    }
}
