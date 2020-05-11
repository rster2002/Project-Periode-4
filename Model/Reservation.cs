using System.Collections.Generic;

namespace Model {
    public class Reservation {
        public int id { get; set; }
        public List<Order> orders { get; set; }
        public Table table { get; set; }
        public Customer customer { get; set; }
    }
}
