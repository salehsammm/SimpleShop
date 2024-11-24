namespace SimpleShop.Models
{
    public class ShopingCart
    {
        public int Id { get; set; }
        public IList<ShopingCartItem>? Products { get; set; }        
    }
}
