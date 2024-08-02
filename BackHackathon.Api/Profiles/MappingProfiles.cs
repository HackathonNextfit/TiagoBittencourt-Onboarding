using AutoMapper;
using BackHackathon.Application.DTOs;
using BackHackathon.Domain.Entities;

namespace BackHackathon.Api.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CreateModalidadeDto, Modalidade>();
        CreateMap<CreateContratoDto, Contrato>();
        CreateMap<CreateConfigAvaliacaoFisicaDto, ConfigAvaliacaoFisica>();
        CreateMap<CreateConfigCaixaDto, ConfigCaixa>();
        CreateMap<CreateUsuarioRecebimentoCaixaDto, UsuarioRecebimentoCaixa>();
        CreateMap<CreateConfigContratoBloqueioDto, ConfigContratoBloqueio>();
    }
}