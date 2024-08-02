using AutoMapper;
using BackHackathon.Application.DTOs;
using BackHackathon.Domain.Entities;

namespace BackHackathon.Api.Profiles;

public class ContratoProfile : Profile
{
    public ContratoProfile()
    {
        CreateMap<CreateContratoDto, Contrato>();
        CreateMap<CreateContratoModalidadeDto, ContratoModalidade>();
    }
}