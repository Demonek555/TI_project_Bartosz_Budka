using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Wpisz nazwę")]
        public string Name { get; set; }
        [StringLength(600,ErrorMessage ="Przekroczony limit znaków")]
        public string Desc { get; set; }
        public ICollection<Film> Films { get; set; }

    }
}
