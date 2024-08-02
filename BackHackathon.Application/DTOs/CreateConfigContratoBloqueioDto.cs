using System.Text.Json.Serialization;

namespace BackHackathon.Application.DTOs;

public class CreateConfigContratoBloqueioDto
{
    [JsonPropertyName("BloquearSemAvaliacaoFisicaOuVencida")]
    public bool BloquearSemAvaliacaoFisicaOuVencida { get; set; }
    
    [JsonPropertyName("BloquearSemExameMedicoOuVencido")]
    public bool BloquearSemExameMedicoOuVencido { get; set; }
    
    [JsonPropertyName("DiasBloquearNaoAssinados")]
    public int DiasBloquearNaoAssinados { get; set; }
    
    [JsonPropertyName("DiasBloquearSemAvaliacaoFisicaOuVencida")]
    public int DiasBloquearSemAvaliacaoFisicaOuVencida { get; set; }
    
    [JsonPropertyName("DiasBloquearSemExameMedicoOuVencido")]
    public int DiasBloquearSemExameMedicoOuVencido { get; set; }
}