namespace SimpleShop.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? PhoneNumber { get; set; }

        //Navigation
        public required List<ShopingCart> ShopingCarts { get; set; }

    }
}
