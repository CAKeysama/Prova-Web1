using System.ComponentModel.DataAnnotations;

namespace ProvaWeb1.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O diretor é obrigatório.")]
        public string Diretor { get; set; }

        public int AnoLancamento { get; set; }
    }
}