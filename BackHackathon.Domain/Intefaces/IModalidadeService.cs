using BackHackathon.Domain.Entities;

namespace BackHackathon.Domain.Intefaces;

public interface IModalidadeService
{
    Task<Modalidade> Criar(Modalidade modalidade);
}