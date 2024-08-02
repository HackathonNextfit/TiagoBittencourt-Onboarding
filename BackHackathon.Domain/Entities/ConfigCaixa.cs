namespace BackHackathon.Domain.Entities;

public class ConfigCaixa
{
    public int Id { get; set; }
    public bool EnviarRelFechamentoParaUsuariosEnvolvidos { get; set; }
    public bool PermiteAbrirMultiplosCaixas { get; set; }
}