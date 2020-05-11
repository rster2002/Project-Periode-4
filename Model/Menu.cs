using System;
using System.Collections.Generic;

namespace Model {
    public class Menu {
        public int id { get; set; }
        public string name { get; set; }
        public TimeSpan startTime { get; set; }
        public TimeSpan endTime { get; set; }
        public List<MenuItem> items { get; set; }
    }
}
