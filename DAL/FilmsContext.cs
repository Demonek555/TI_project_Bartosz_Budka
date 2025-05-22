using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class FilmsContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Category> Categories { get; set; }
        public FilmsContext(DbContextOptions<FilmsContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var categories = new List<Category>()
            {
            new Category { CategoryId = 1, Name = "Akcja", Desc = "Filmy pełne dynamicznych scen i efektów specjalnych." },
            new Category { CategoryId = 2, Name = "Komedia", Desc = "Filmy zapewniające rozrywkę i humor." },
            new Category { CategoryId = 3, Name = "Dramat", Desc = "Filmy o głębokich emocjach i poważnych tematach." },
            new Category { CategoryId = 4, Name = "Horror", Desc = "Filmy, które wywołują strach i napięcie." },
            new Category { CategoryId = 5, Name = "Sci-Fi", Desc = "Filmy opowiadające o futurystycznych technologiach i kosmosie." },
            new Category { CategoryId = 6, Name = "Fantasy", Desc = "Filmy pełne magii i niezwykłych światów." },
            new Category { CategoryId = 7, Name = "Thriller", Desc = "Filmy trzymające w napięciu z nieoczekiwanymi zwrotami akcji." },
            new Category { CategoryId = 8, Name = "Animacja", Desc = "Filmy animowane, często dla dzieci i rodzin." },
            new Category { CategoryId = 9, Name = "Dokumentalny", Desc = "Filmy oparte na faktach i rzeczywistych wydarzeniach." },
            new Category { CategoryId = 10, Name = "Romans", Desc = "Filmy o miłości i relacjach międzyludzkich." }
            };
            var films = new List<Film>()
            {
            new Film { Poster ="Mad_Max.png", FilmId = 1, Title = "Mad Max: Na drodze gniewu", Director = "George Miller", Desc = "Postapokaliptyczna walka o przetrwanie.", Price = 29.99m, CategoryId = 1 },
            new Film { Poster ="Gladiator.png", FilmId = 2, Title = "Gladiator", Director = "Ridley Scott", Desc = "Historia rzymskiego generała, który staje się gladiatorem.", Price = 34.99m, CategoryId = 1 },
            new Film { Poster ="deadpool.png", FilmId = 3, Title = "Deadpool", Director = "Tim Miller", Desc = "Bohater z ciętym językiem i niezwykłymi umiejętnościami.", Price = 24.99m, CategoryId = 2 },
            new Film { Poster ="forest_gump.png", FilmId = 4, Title = "Forrest Gump", Director = "Robert Zemeckis", Desc = "Historia człowieka, który przypadkiem wpływa na historię świata.", Price = 19.99m, CategoryId = 3 },
            new Film { Poster ="alien.png", FilmId = 5, Title = "Obcy: Ósmy pasażer Nostromo", Director = "Ridley Scott", Desc = "Załoga statku kosmicznego walczy z obcym stworzeniem.", Price = 39.99m, CategoryId = 4 },
            new Film { Poster ="matrix.png", FilmId = 6, Title = "Matrix", Director = "Lana i Lilly Wachowski", Desc = "Rzeczywistość to iluzja kontrolowana przez maszyny.", Price = 29.99m, CategoryId = 5 },
            new Film { Poster ="władca.png", FilmId = 7, Title = "Władca Pierścieni: Drużyna Pierścienia", Director = "Peter Jackson", Desc = "Podróż Froda i jego towarzyszy w celu zniszczenia pierścienia.", Price = 49.99m, CategoryId = 6 },
            new Film { Poster ="incepcja.png", FilmId = 8, Title = "Incepcja", Director = "Christopher Nolan", Desc = "Złodziej kradnie sekrety z umysłów podczas snu.", Price = 34.99m, CategoryId = 7 },
            new Film { Poster ="shrek.png", FilmId = 9, Title = "Shrek", Director = "Andrew Adamson, Vicky Jenson", Desc = "Ogr wyrusza na misję, by odzyskać swoje bagno.", Price = 14.99m, CategoryId = 8 },
            new Film { Poster ="ziemia.png", FilmId = 10, Title = "Ziemia: Niezwykły dzień", Director = "Richard Dale", Desc = "Dokument ukazujący piękno naszej planety.", Price = 24.99m, CategoryId = 9 },
            new Film { Poster ="titanic.png", FilmId = 11, Title = "Titanic", Director = "James Cameron", Desc = "Historia miłości na pokładzie słynnego statku.", Price = 19.99m, CategoryId = 10 },
            new Film { Poster ="john_wick.png", FilmId = 12, Title = "John Wick", Director = "Chad Stahelski", Desc = "Zabójca wraca do gry, by pomścić stratę.", Price = 29.99m, CategoryId = 1 },
            new Film { Poster ="superbad.png", FilmId = 13, Title = "Superbad", Director = "Greg Mottola", Desc = "Dwoje przyjaciół próbuje przeżyć zwariowaną noc.", Price = 19.99m, CategoryId = 2 },
            new Film { Poster ="ciche_miejsce.png", FilmId = 14, Title = "Ciche miejsce", Director = "John Krasinski", Desc = "Rodzina ukrywa się przed potworami reagującymi na dźwięk.", Price = 27.99m, CategoryId = 4 },
            new Film { Poster ="interseller.png", FilmId = 15, Title = "Interstellar", Director = "Christopher Nolan", Desc = "Misja kosmiczna w poszukiwaniu nowego domu dla ludzkości.", Price = 39.99m, CategoryId = 5 },
            new Film { Poster ="potter.png", FilmId = 16, Title = "Harry Potter i Kamień Filozoficzny", Director = "Chris Columbus", Desc = "Młody czarodziej odkrywa swoje przeznaczenie.", Price = 29.99m, CategoryId = 6 },
            new Film { Poster ="joker.png", FilmId = 17, Title = "Joker", Director = "Todd Phillips", Desc = "Portret psychologiczny upadku człowieka.", Price = 31.99m, CategoryId = 3 },
            new Film { Poster ="toystory.png", FilmId = 18, Title = "Toy Story", Director = "John Lasseter", Desc = "Zabawki ożywają, gdy ludzie ich nie widzą.", Price = 19.99m, CategoryId = 8 },
            new Film { Poster ="mononoke.png", FilmId = 19, Title = "Księżniczka Mononoke", Director = "Hayao Miyazaki", Desc = "Opowieść o walce między naturą a cywilizacją.", Price = 34.99m, CategoryId = 6 },
            new Film { Poster ="szeregowiec.png", FilmId = 20, Title = "Szeregowiec Ryan", Director = "Steven Spielberg", Desc = "Oddział wyrusza na misję ratunkową podczas II wojny światowej.", Price = 39.99m, CategoryId = 1 }

            };
            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Film>().HasData(films);
        }
    }
}
