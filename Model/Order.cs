namespace Model {
    public class Order {
        public int id { get; set; }
        public Table table { get; set; }
        public Staff placedBy { get; set; }
    }
}
