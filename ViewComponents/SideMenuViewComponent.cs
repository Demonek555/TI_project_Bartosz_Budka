using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL;

namespace WebApplication1.ViewComponents
{
    public class SideMenuViewComponent :ViewComponent
    {
        FilmsContext db;
        public SideMenuViewComponent(FilmsContext db)
        {
            this.db = db;
        }
        
        public async Task<IViewComponentResult> InvokeAsync(string categoryName)
        {
            var category = db.Categories.Include("Films").Where(c => c.Name.ToUpper() == categoryName.ToUpper()).FirstOrDefault();
            var films = category.Films.OrderBy(f => f.Title).ToList();
            return await Task.FromResult(View("_SideMenu", films));
        }
    }
}
