using System.ComponentModel.DataAnnotations;

namespace ProvaNetCore.Models
{
    public class Conta
    {
        [Key]
        [Required(ErrorMessage = "O campo id é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [MaxLength(75)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        [MaxLength(150)]
        public string Descricao { get; set; }
    }
}
