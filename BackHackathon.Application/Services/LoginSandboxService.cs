using System.Text.Json;
using BackHackathon.Application.Constants;
using BackHackathon.Domain.Entities;
using BackHackathon.Domain.Intefaces;

namespace BackHackathon.Application.Services;

public class LoginSandboxService : ILoginSandboxService
{
    public async Task<Token> Login()
    {
        var usuario = new Usuario()
        {
            Username = "tiago.bittencourt@nextfit.com.br",
            Password = "@tiagonextfit_lol"
        };
        
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Post, SandboxApiConfig.Endpoints.Token);
        
        var collection = new List<KeyValuePair<string, string>>
        {
            new("username", usuario.Username),
            new("password", usuario.Password),
            new("grant_type", "password")
        };

        request.Content = new FormUrlEncodedContent(collection);
        var response = await client.SendAsync(request);
        
        response.EnsureSuccessStatusCode();
        var responseContent = await response.Content.ReadAsStringAsync();

        var responseBase = JsonSerializer.Deserialize<Token>(responseContent);
        
        return responseBase;
    }
}