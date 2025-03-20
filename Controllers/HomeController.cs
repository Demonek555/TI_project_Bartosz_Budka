using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    FilmsContext db;

    public HomeController(FilmsContext db)
    {
        this.db = db;
    }

    public IActionResult Index()
    {
        var kategorie = db.Categories.ToList();
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

   public IActionResult footerSites(string viewName)
    {
        return View(viewName);
    }
}
