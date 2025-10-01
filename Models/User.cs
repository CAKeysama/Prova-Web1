using System.ComponentModel.DataAnnotations;

namespace ProvaWeb1.Models
{
    // Modelo de Usuário que será salvo no "banco em memória"
    public class User
    {
        [Key] // Define a chave primária
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório.")]
        [Phone(ErrorMessage = "Telefone inválido.")]
        public string Telefone { get; set; }
    }
}
