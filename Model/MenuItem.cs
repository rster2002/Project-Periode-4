namespace Model {
    public class MenuItem {
        public int Id { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int VAT { get; set; }
        public int AmountInStock { get; set; }
        public string Comment { get; set; }
        public string Type { get; set; }
        public string Subtype { get; set; }
    }
}
