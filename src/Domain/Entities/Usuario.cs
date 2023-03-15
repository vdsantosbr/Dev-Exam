

using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Usuario
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(255, ErrorMessage ="Quantidade de Caracteres invalido")]
        public string Nome { get; set; }
        [MaxLength(255, ErrorMessage = "Quantidade de Caracteres invalido")]
        public string Sobrenome { get; set; }
        [MaxLength(255, ErrorMessage = "Quantidade de Caracteres invalido")]
        public string Email { get; set; }
        [MaxLength(255, ErrorMessage = "Quantidade de Caracteres invalido")]
        public string Login { get; set; }
        public string Senha { get; set; }
        [Range(10,100, ErrorMessage ="Idade invalida")]
        public int Idade { get; set; }
    }
}
