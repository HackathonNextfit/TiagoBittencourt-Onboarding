using AutoMapper;
using BackHackathon.Application.DTOs;
using BackHackathon.Domain.Entities;

namespace BackHackathon.Api.Profiles;

public class ConfigContratoBloqueioProfile : Profile
{
    public ConfigContratoBloqueioProfile()
    {
        CreateMap<CreateConfigContratoBloqueioDto, ConfigContratoBloqueio>();
    }
}