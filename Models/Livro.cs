using System.ComponentModel.DataAnnotations;

namespace ProvaWeb1.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O t�tulo � obrigat�rio.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O autor � obrigat�rio.")]
        public string Autor { get; set; }

        public int AnoPublicacao { get; set; }
    }
}