namespace SimpleShop.Models
{
    public class ShopingCartItem
    {
        public int Id { get; set; }
        public int Count { get; set; }

        //Navigation
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int ShopingCartId { get; set; }
        public ShopingCart? ShopingCart { get; set; }
    }
}
