namespace FashionStore.Data
{
    public class Order
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public int Status { get; set; }
        public string ClotherName { get; set; }
        public string ClotherImage { get; set; }
        public double Price { get; set; } 
        public int Amount { get; set; }
    }
}
