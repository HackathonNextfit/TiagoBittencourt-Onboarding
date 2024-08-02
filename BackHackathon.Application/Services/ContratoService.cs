using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using BackHackathon.Application.Constants;
using BackHackathon.Domain.Entities;
using BackHackathon.Domain.Intefaces;

namespace BackHackathon.Application.Services;

public class ContratoService : IContratoService
{
    private readonly ILoginSandboxService _loginSandboxService;
    private readonly IUnidadeService _unidadeService;

    public ContratoService(ILoginSandboxService loginSandboxService, IUnidadeService unidadeService)
    {
        _loginSandboxService = loginSandboxService;
        _unidadeService = unidadeService;
    }
    
    public async Task<Contrato> Criar(Contrato contrato)
    {
        var token = await _loginSandboxService.Login();
        
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Post, SandboxApiConfig.Endpoints.InserirContrato);

        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);
        
        var jsonBody = JsonSerializer.Serialize(contrato);
        
        request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
        
        var response = await client.SendAsync(request);

        response.EnsureSuccessStatusCode();

        var responseContent = await response.Content.ReadAsStringAsync();
        
        var responseJson = JsonSerializer.Deserialize<ApiBaseResponse<Contrato>>(responseContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        
        contrato.Id = responseJson.Content.Id;

        return contrato;
    }
}