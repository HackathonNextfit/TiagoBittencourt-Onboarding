using BackHackathon.Domain.Entities;

namespace BackHackathon.Domain.Intefaces;

public interface IConfigCaixaService
{
    Task Configurar(ConfigCaixa configCaixa);
    Task ConfigurarNotificarUsuarioFechamento(UsuarioRecebimentoCaixa usuarioRecebimentoCaixa);
}