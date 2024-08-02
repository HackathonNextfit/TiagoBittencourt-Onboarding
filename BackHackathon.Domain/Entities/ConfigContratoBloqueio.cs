namespace BackHackathon.Domain.Entities;

public class ConfigContratoBloqueio
{
    public int Id { get; set; } = 8268;
    public bool BloquearSemAvaliacaoFisicaOuVencida { get; set; }
    public bool BloquearSemExameMedicoOuVencido { get; set; }
    public int? CodigoTenant { get; set; } = 8545;
    public int? CodigoUnidade { get; set; } = 8545;
    public int? CodigoUsuarioAlteracao { get; set; } = 85377;
    public int? CodigoUsuarioCriacao { get; set; } = 85377;
    public DateTime? DataAlteracao { get; set; }
    public DateTime? DataCriacao { get; set; }
    public int DiasBloquearNaoAssinados { get; set; }
    public int DiasBloquearSemAvaliacaoFisicaOuVencida { get; set; }
    public int DiasBloquearSemExameMedicoOuVencido { get; set; }
    public object? Tenant { get; set; } = null;
    public object? Unidade { get; set; } = null;
}