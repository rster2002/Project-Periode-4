﻿using System;

namespace Model {
    public class Order {
        public int Id { get; set; }
        public Table Table { get; set; }
        public Staff PlacedBy { get; set; }
        public DateTime PlacedAt { get; set; }
    }
}
