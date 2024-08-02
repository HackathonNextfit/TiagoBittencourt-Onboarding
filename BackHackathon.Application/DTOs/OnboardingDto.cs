namespace BackHackathon.Application.DTOs;

public class OnboardingDto
{
    public CreateModalidadeDto? ModalidadeDto { get; set; }
    public CreateContratoDto? ContratoDto { get; set; }
    public CreateConfigAvaliacaoFisicaDto? ConfigAvaliacaoFisicaDto { get; set; }
    public CreateConfigCaixaDto? ConfigCaixaDto { get; set; }
    public CreateUsuarioRecebimentoCaixaDto? UsuarioRecebimentoCaixaDto { get; set; }
    public CreateConfigContratoBloqueioDto? ConfigContratoBloqueioDto { get; set; }
}