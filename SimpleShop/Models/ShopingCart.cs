namespace SimpleShop.Models
{
    public class ShopingCart
    {
        public int Id { get; set; }

        //Navigation
        public IList<ShopingCartItem>? Products { get; set; }

        public required User User { get; set; }
        public int UserId { get; set; }
    }
}
