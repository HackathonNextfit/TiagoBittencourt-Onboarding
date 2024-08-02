using BackHackathon.Domain.Entities;

namespace BackHackathon.Domain.Intefaces;

public interface IContratoService
{
    Task<Contrato> Criar(Contrato contrato);
}