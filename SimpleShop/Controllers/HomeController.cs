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
            var products = _context.Products.ToList();

            return View(products);
        }

        public IActionResult ProductDetail()
        {
            return View();
        }

        public JsonResult AddToCart(int productId)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == productId);
            //if (!(_context.shopingCarts.Any()))
            //{
            //    var shoppingCart = new ShopingCart();
            //}

            var shoppingCartItem = new ShopingCartItem()
            {
                ProdcutId = productId,
                //CartId = 1,
                Count = 1
            };
            _context.shopingCartItems.Add(shoppingCartItem);

            return Json(product);
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
    }
}
