using BackHackathon.Api.Filters;
using BackHackathon.Api.Profiles;
using BackHackathon.Application.Services;
using BackHackathon.Domain.Intefaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(cfg =>
{
    cfg.Filters.Add<ApiBaseResponseFilter>();
});

builder.Services.AddScoped<ILoginSandboxService, LoginSandboxService>();
builder.Services.AddScoped<IModalidadeService, ModalidadeService>();
builder.Services.AddScoped<IUnidadeService, UnidadeService>();
builder.Services.AddScoped<IContratoService, ContratoService>();
builder.Services.AddScoped<IConfigAvaliacaoFisicaService, ConfigAvaliacaoFisicaService>();
builder.Services.AddScoped<IConfigCaixaService, ConfigCaixaService>();
builder.Services.AddScoped<IConfigContratoBloqueioService, ConfigContratoBloqueioService>();

builder.Services.AddAutoMapper(typeof(MappingProfiles));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();