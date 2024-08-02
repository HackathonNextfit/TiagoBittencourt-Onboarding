using BackHackathon.Domain.Entities;
using BackHackathon.Domain.Intefaces;

namespace BackHackathon.Application.Services;

public class UnidadeService : IUnidadeService
{
    private readonly Unidade unidade;

    public UnidadeService()
    {
        unidade = new Unidade()
        {
            Id = 8545,
            CodigoUnidade = 8545,
            Fantasia = "Academia Gal",
            Endereco = "Rua Doutor Jairo Frank",
            NumEndereco = 235,
            Cidade = "Criciúma"
        };
    }
    
    public Unidade Recuperar()
    {
        return unidade;
    }
}