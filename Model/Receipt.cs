using System.Collections.Generic;

namespace Model {
    public class Receipt {
        public int Id { get; set; }
        public List<Order> Orders { get; set; }
    }
}
