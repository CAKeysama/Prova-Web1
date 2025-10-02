using System.ComponentModel.DataAnnotations;

namespace ProvaWeb1.Models
{
    public class Comida
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }

        public string Tipo { get; set; } // Ex: Sobremesa, Prato Principal
    }
}