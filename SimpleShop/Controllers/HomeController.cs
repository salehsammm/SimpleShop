using Microsoft.AspNetCore.Mvc;
using SimpleShop.Data;
using SimpleShop.Models;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SimpleShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ShopContext _context;
        public HomeController(ILogger<HomeController> logger , ShopContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductDetail()
        {
            return View();
        }

		private static List<ShopingCartItem> TemporaryCart = new List<ShopingCartItem>();
		public JsonResult AddToCart(int productId)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == productId);
			var cartItem = TemporaryCart.FirstOrDefault(item => item.ProductId == productId);
			if (cartItem != null)
			{
				cartItem.Count++;
			}
			else
			{				
				TemporaryCart.Add(new ShopingCartItem
				{
					Id = TemporaryCart.Count + 1,
					ProductId = productId,
					Product = product,
					Count = 1
				});
			}


			return Json(TemporaryCart.Select(item => new
			{
				item.Id,
				item.Product?.Name,
				item.Product?.Price,
				item.Count
			}));
		}

        public JsonResult GoToDetail()
        {
            return Json(1);
        }

        [HttpGet]
        public JsonResult GetProducts()
        {
            indexData data = new indexData()
            {
                products = _context.Products.ToList(),
                shopingCartItems = _context.shopingCartItems.ToList()
            };

            return Json(data);
        }

		public JsonResult DeleteProduct(int productId)
		{
			var removeItem = TemporaryCart.FirstOrDefault(item => item.ProductId == productId);
			if (removeItem != null)
			{
				TemporaryCart.Remove(removeItem);
			}

			return Json(TemporaryCart.Select(item => new
			{
				item.Id,
				item.Product?.Name,
				item.Product?.Price,
				item.Count
			}));
		}
	}
}
