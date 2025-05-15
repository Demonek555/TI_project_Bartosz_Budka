using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL;
using WebApplication1.Infrastructure;
using WebApplication1.Models;

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
        public IActionResult AddToCart(int filmId/*, string returnUrl = null*/)
        {
            CartManager.AddToCart(HttpContext.Session, filmId, db);
            //if (!string.IsNullOrEmpty(returnUrl))
            //{
            //    return Redirect(returnUrl);
            //}
            return RedirectToAction("Index");
        }
        public IActionResult RemoveFromCart(int id)
        {
            var model = new RemoveViewModel()
            {
                itemId = id,
                itemQuantity = CartManager.RemoveFromCart(HttpContext.Session, id),
                cartValue = CartManager.GetCartValue(HttpContext.Session)
            };
            return Json(model);
        }
        
    }
}
