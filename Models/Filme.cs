using System.ComponentModel.DataAnnotations;

namespace ProvaWeb1.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O t�tulo � obrigat�rio.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O diretor � obrigat�rio.")]
        public string Diretor { get; set; }

        public int AnoLancamento { get; set; }
    }
}