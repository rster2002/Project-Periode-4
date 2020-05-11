using System.Collections.Generic;

namespace Model {
    public class Receipt {
        public int id { get; set; }
        public Register register { get; set; }
        public List<Order> orders { get; set; }
    }
}
