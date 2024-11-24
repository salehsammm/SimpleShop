namespace SimpleShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Price { get; set; }
        public string? ImgUrl { get; set; }
    }
}
