using BackHackathon.Domain.Entities;

namespace BackHackathon.Domain.Intefaces;

public interface IConfigAvaliacaoFisicaService
{
    Task<ConfigAvaliacaoFisica> Configurar(ConfigAvaliacaoFisica config);
}