using BackHackathon.Domain.Entities;

namespace BackHackathon.Domain.Intefaces;

public interface IConfigContratoBloqueioService
{
    Task<ConfigContratoBloqueio> Configurar(ConfigContratoBloqueio config);
}