namespace WebApplication1.Models
{
    public class KategoriaViewModel
    {
        public Category Kategoria { get; set; }
        public IEnumerable<Film> FilmyKategorii { get; set; }
        public IEnumerable<Film> FilmyNajnowsze { get; set; }
    }

}
