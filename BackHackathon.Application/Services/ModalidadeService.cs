using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using BackHackathon.Application.Constants;
using BackHackathon.Domain.Entities;
using BackHackathon.Domain.Intefaces;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace BackHackathon.Application.Services;

public class ModalidadeService : IModalidadeService
{
    private readonly ILoginSandboxService _loginSandboxService;

    public ModalidadeService(ILoginSandboxService loginSandboxService)
    {
        _loginSandboxService = loginSandboxService;
    }
    
    public async Task<Modalidade> Criar(Modalidade modalidade)
    {
        var token = await _loginSandboxService.Login();

        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Post, SandboxApiConfig.Endpoints.InserirModalidade);

        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);

        var jsonBody = JsonSerializer.Serialize(modalidade);
        
        request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

        var response = await client.SendAsync(request);

        response.EnsureSuccessStatusCode();

        var responseContent = await response.Content.ReadAsStringAsync();
        
        var responseJson = JsonSerializer.Deserialize<ApiBaseResponse<Modalidade>>(responseContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        
        modalidade.Id = responseJson.Content.Id;

        return modalidade;
    }
}