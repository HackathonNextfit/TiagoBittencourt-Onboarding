using BackHackathon.Domain.Entities;

namespace BackHackathon.Domain.Intefaces;

public interface ILoginSandboxService
{
    Task<Token> Login();
}