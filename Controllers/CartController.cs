using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL;
using WebApplication1.Infrastructure;

namespace WebApplication1.Controllers
{
    public class CartController : Controller
    {
        FilmsContext db;
        public CartController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var cart = CartManager.GetItems(HttpContext.Session);
            ViewBag.Total = CartManager.GetCartValue(HttpContext.Session);
            return View(cart);
        }
        public IActionResult AddToCart(int filmId)
        {
            CartManager.AddToCart(HttpContext.Session, filmId, db);
            return RedirectToAction("Index","Cart");
        }
        
    }
}
