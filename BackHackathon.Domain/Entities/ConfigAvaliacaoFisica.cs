using BackHackathon.Domain.Enums;

namespace BackHackathon.Domain.Entities;

public class ConfigAvaliacaoFisica
{
    public int Id { get; set; }
    public bool CalculaImc { get; set; }
    public bool CalculaPesoIdeal { get; set; }
    public int CodigoTenant { get; set; } = 8545;
    public int CodigoUsuarioAlteracao { get; set; } = 85377;
    public int CodigoUsuarioCriacao { get; set; } = 85377;
    public DateTime DataAlteracao { get; set; } = DateTime.Now;
    public DateTime DataCriacao { get; set; } = DateTime.Now;
    public int QtdeDiasProximaAvaliacao { get; set; }
    public object? Tenant { get; set; } = null;
    public ETipoUnidadeMedida TipoUnidadeMedidaAltura { get; set; }
}