using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Director { get; set; }
        [StringLength(600,ErrorMessage ="Przekroczono limit znaków")]
        public string Desc { get; set; }
        public decimal? Price { get; set; }
        public string Poster { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
    }
}
