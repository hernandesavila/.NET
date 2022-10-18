using FluentResults;
using Microsoft.AspNetCore.Mvc;
using ProvaNetCore.Data.Dtos.Conta;
using ProvaNetCore.Services;

namespace ProvaNetCore.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ContaController : ControllerBase
    {
        ContaService _contaService;

        public ContaController(ContaService contaService)
        {
            _contaService = contaService;
        }

        [HttpPost]
        public IActionResult CadastrarConta([FromBody] CreateContaDto createContaDto)
        {
            ReadContaDto readContaDto = _contaService.CriarConta(createContaDto);

            return CreatedAtAction(nameof(CadastrarConta), new { Id = readContaDto.Id }, readContaDto);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaConta(int id, [FromBody] UpdateContaDto updateContaDto)
        {
            Result resultado = _contaService.AtualizaConta(id, updateContaDto);

            if (resultado.IsFailed)
                return NotFound(resultado.Errors);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaConta(int id)
        {
            Result resultado = _contaService.DeletaConta(id);

            if (resultado.IsFailed)
                return NotFound(resultado.Errors);

            return NoContent();
        }

        [HttpGet]
        public IActionResult ListarContas([FromQuery] string? nomeConta)
        {
            List<ReadContaDto> listReadContaDto = _contaService.ListarContas(nomeConta);

            if (listReadContaDto != null)
                return Ok(listReadContaDto);

            return NotFound("Não há dados a serem retornados");
        }


        [HttpGet("{id}")]
        public IActionResult RecuperarContaPorId(int id)
        {
            ReadContaDto readCinemaDto = _contaService.RecuperarContaPorId(id);

            if (readCinemaDto != null)
                return Ok(readCinemaDto);

            return NotFound("Não há dados a serem retornados");
        }
    }
}
