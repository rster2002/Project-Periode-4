using System;
using System.Collections.Generic;

namespace Model {
    public class Menu {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public List<MenuItem> Items { get; set; }
    }
}
