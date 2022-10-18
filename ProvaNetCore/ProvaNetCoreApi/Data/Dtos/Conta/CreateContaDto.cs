using System.ComponentModel.DataAnnotations;

namespace ProvaNetCore.Data.Dtos.Conta
{
    public class CreateContaDto
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Descricao { get; set; }
    }
}
