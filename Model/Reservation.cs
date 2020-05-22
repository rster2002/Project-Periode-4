using System.Collections.Generic;

namespace Model {
    public class Reservation {
        public int Id { get; set; }
        public List<Order> Orders { get; set; }
        public Table Table { get; set; }
        public Customer Customer { get; set; }

        public Reservation() {
            Orders = new List<Order>();
        }
    }
}
