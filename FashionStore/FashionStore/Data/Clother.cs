namespace FashionStore.Data
{
    public class Clother
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public int IsDeleted { get; set; }
        public double Price { get; set; }
        public int BrandId  { get; set; }
        public string BrandName { get; set; }
    }
}
