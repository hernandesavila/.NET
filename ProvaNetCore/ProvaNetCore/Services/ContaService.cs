using AutoMapper;
using FluentResults;
using ProvaNetCore.Data;
using ProvaNetCore.Data.Dtos.Conta;
using ProvaNetCore.Models;

namespace ProvaNetCore.Services
{
    public class ContaService
    {
        private ProvaNetCoreDbContext _context;
        private IMapper _mapper;

        public ContaService(ProvaNetCoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadContaDto CriarConta(CreateContaDto createContaDto)
        {
            Conta conta = _mapper.Map<Conta>(createContaDto);

            _context.Contas.Add(conta);
            _context.SaveChanges();

            return _mapper.Map<ReadContaDto>(conta);
        }

        public Result AtualizaConta(int id, UpdateContaDto updateContaDto)
        {
            Conta conta = _context.Contas.FirstOrDefault(conta => conta.Id == id);

            if(conta == null)
            {
                return Result.Fail("Conta não encontrada");
            }

            _mapper.Map(updateContaDto, conta);
            _context.SaveChanges();

            return Result.Ok();
        }

        public Result DeletaConta(int id)
        {
            Conta conta = _context.Contas.FirstOrDefault(conta => conta.Id == id);

            if(conta ==  null)
            {
                return Result.Fail("Conta não encontrada");
            }

            _context.Remove(conta);
            _context.SaveChanges();

            return Result.Ok();
        }

        public List<ReadContaDto> ListarContas(string nomeConta) 
        {
            List<Conta> contas = _context.Contas.ToList();

            if(!string.IsNullOrEmpty(nomeConta))
            {
                contas = contas.Where(conta => conta.Nome == nomeConta).ToList();
            }

            return _mapper.Map<List<ReadContaDto>>(contas);
        }

        public ReadContaDto RecuperarContaPorId(int id)
        {
            Conta conta = _context.Contas.FirstOrDefault(conta => conta.Id == id);

            if (conta != null)
            {
                return _mapper.Map<ReadContaDto>(conta);
            }

            return null;
        }
    }
}
