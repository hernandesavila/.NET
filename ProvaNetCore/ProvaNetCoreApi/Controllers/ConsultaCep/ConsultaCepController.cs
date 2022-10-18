using Microsoft.AspNetCore.Mvc;
using ProvaNetCore.Data.Dtos.ConsultaCep;
using ProvaNetCore.Services;

namespace ProvaNetCore.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ConsultaCepController : ControllerBase
    {
        ConsultaCepService _consultaCepService;

        public ConsultaCepController(ConsultaCepService consultaCepService)
        {
            _consultaCepService = consultaCepService;
        }

        [HttpGet("{cep}")]
        public IActionResult ConsultaCep(string cep)
        {
            ConsultaCepResponseDto consultaCepResponseDto = _consultaCepService.ConsultaCep(cep);

            if (consultaCepResponseDto == null)
                return StatusCode(500, "Não foi possível executar a consulta de CEP");

            return Ok(consultaCepResponseDto);
        }
    }
}
