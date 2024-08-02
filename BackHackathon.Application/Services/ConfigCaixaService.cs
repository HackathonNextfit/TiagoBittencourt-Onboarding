using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using BackHackathon.Application.Constants;
using BackHackathon.Domain.Entities;
using BackHackathon.Domain.Intefaces;

namespace BackHackathon.Application.Services;

public class ConfigCaixaService : IConfigCaixaService
{

    private readonly ILoginSandboxService _loginSandboxService;

    public ConfigCaixaService(ILoginSandboxService loginSandboxService)
    {
        _loginSandboxService = loginSandboxService;
    }
    
    public async Task Configurar(ConfigCaixa configCaixa)
    {
        var token = await _loginSandboxService.Login();
        
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Put, SandboxApiConfig.Endpoints.ConfigCaixa);
        
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);
        
        var jsonBody = JsonSerializer.Serialize(configCaixa);
        
        request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
        
        var response = await client.SendAsync(request);

        response.EnsureSuccessStatusCode();
    }

    public async Task ConfigurarNotificarUsuarioFechamento(UsuarioRecebimentoCaixa usuarioRecebimentoCaixa)
    {
        var token = await _loginSandboxService.Login();
        
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Post, SandboxApiConfig.Endpoints.ConfigCaixaNotifUsuarioFechamento);
        
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);

        var jsonBody = JsonSerializer.Serialize(usuarioRecebimentoCaixa);
        
        request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
        
        var response = await client.SendAsync(request);

        response.EnsureSuccessStatusCode();
    }
}