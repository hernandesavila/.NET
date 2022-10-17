using System.ComponentModel.DataAnnotations;

namespace ProvaNetCore.Data.Dtos.Conta
{
    public class UpdateContaDto
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Descricao { get; set; }
    }
}
