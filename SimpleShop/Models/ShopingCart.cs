namespace SimpleShop.Models
{
    public class ShopingCart
    {
        public int Id { get; set; }
        public IList<ShopingCartItem> products { get; set; }
        public int totalPrice { get; set; }
    }
}
