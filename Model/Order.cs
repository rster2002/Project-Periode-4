using System;
using System.Collections.Generic;

namespace Model {
    public class Order {
        public int Id { get; set; }
        public Staff PlacedBy { get; set; }
        public List<MenuItem> MenuItems { get; set; }
        public DateTime PlacedAt { get; set; }
        public string Tag { get; set; }
        public string Status { get; set; }

        public Order() {
            MenuItems = new List<MenuItem>();
        }
    }
}
