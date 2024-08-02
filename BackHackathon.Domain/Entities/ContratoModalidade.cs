namespace BackHackathon.Domain.Entities;

public class ContratoModalidade
{
    public int CodigoModalidade { get; set; }
    public bool DiaHorarioLivre { get; set; } = true;
    public int TipoLimiteAcessoPorPeriodo { get; set; } = 1;
    public object? QtdeLimiteAcessosPorPeriodo { get; set; } = null;
    public int Tipo { get; set; } = 1;
}