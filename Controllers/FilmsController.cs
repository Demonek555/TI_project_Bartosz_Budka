using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FilmsController : Controller
    {
        FilmsContext db;

        public FilmsController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult AllFilms()
        {
            return View(db.Films.ToList());
        }

        public IActionResult FilmsList(string categoryName)
        {
            var category = db.Categories.Include("Films").Where(c => c.Name.ToUpper() == categoryName.ToUpper()).Single();
            var films = category.Films.ToList();
            KategoriaViewModel model = new KategoriaViewModel();
            model.Kategoria = category;
            model.FilmyKategorii = films;
            model.FilmyNajnowsze = db.Films.OrderByDescending(f => f.FilmId).Take(3);
            return View(films);
        }

        public IActionResult Details(int filmId)
        {
            var film = db.Films.Find(filmId);
            if(film != null)
            {
                db.Categories.Find(film.CategoryId);
            }
            return View(film);
        }
    }
}
