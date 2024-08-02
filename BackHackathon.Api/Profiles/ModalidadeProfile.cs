using AutoMapper;
using BackHackathon.Application.DTOs;
using BackHackathon.Domain.Entities;

namespace BackHackathon.Api.Profiles;

public class ModalidadeProfile : Profile
{
    public ModalidadeProfile()
    {
        CreateMap<CreateModalidadeDto, Modalidade>();
    }
}