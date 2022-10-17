using AutoMapper;
using ProvaNetCore.Data.Dtos.Conta;
using ProvaNetCore.Models;

namespace ProvaNetCore.Profiles
{
    public class ContaProfile : Profile
    {
        public ContaProfile()
        {
            CreateMap<CreateContaDto, Conta>();
            CreateMap<UpdateContaDto, Conta>();
            CreateMap<Conta, ReadContaDto>();
        }
    }
}
