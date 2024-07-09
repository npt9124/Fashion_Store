namespace FashionStore.Data
{
    public class Cart
    {
        public int Id { get; set; }
        public string ClotherName { get; set; }
        public string ClotherImage { get; set; }
        public int ClotherId { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
    }
}
