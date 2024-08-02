using AutoMapper;
using BackHackathon.Domain.Enums;

namespace BackHackathon.Application.DTOs;

public class CreateContratoDto
{
    public string Descricao { get; set; }
    public ETipoDuracao TipoDuracao { get; set; }
    public int TempoDuracao { get; set; }
    public decimal ValorTotal { get; set; }
    public List<CreateContratoModalidadeDto> Modalidades { get; set; }
}