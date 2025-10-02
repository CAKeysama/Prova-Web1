using System.ComponentModel.DataAnnotations;

namespace ProvaWeb1.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O autor é obrigatório.")]
        public string Autor { get; set; }

        public int AnoPublicacao { get; set; }
    }
}