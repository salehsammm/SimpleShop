namespace SimpleShop.Models
{
    public class ShopingCartItem
    {
        public int id { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }

        //Navigation
        public int ProdcutId { get; set; }
        public Product product { get; set; }

        public int CartId { get; set; }
        public ShopingCart shopingCart { get; set; }
    }
}
