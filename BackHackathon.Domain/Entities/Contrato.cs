using BackHackathon.Domain.Enums;

namespace BackHackathon.Domain.Entities;

public class Contrato
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public int TempoDuracao { get; set; }
    public int Tipo { get; set; } = 1;
    public ETipoDuracao TipoDuracao { get; set; }
    public decimal ValorTotal { get; set; }
    public List<ContratoModalidade> Modalidades { get; set; } = new();

    public int CodigoCategoriaReceita { get; set; } = 88417;
    public bool ContabilizarAulasFormaConjunta { get; set; } = false;
    public string DataFimVenda { get; set; } = "";
    public string DataInicioVenda { get; set; } = "";
    public bool PermiteDefinirRenovacaoAutomaticaNaVenda { get; set; } = false;
    public int TipoRecebimento { get; set; } = 1;
    public int TipoCobrancaAdesao { get; set; } = 1;
    public string ValorPromocional { get; set; } = "100.00";
}