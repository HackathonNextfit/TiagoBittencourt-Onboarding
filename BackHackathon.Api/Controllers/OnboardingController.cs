using AutoMapper;
using BackHackathon.Application.DTOs;
using BackHackathon.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using BackHackathon.Domain.Intefaces;

namespace BackHackathon.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OnboardingController : ControllerBase
    {
        private readonly ILoginSandboxService _login;
        private readonly IModalidadeService _modalidadeService;
        private readonly IContratoService _contratoService;
        private readonly IConfigAvaliacaoFisicaService _configAvaliacaoFisicaService;
        private readonly IConfigCaixaService _configCaixaService;
        private readonly IConfigContratoBloqueioService _configContratoBloqueioService;
        private readonly IMapper _mapper;

        public OnboardingController(ILoginSandboxService login,
            IModalidadeService modalidadeService,
            IContratoService contratoService,
            IConfigAvaliacaoFisicaService configAvaliacaoFisicaService,
            IConfigCaixaService configCaixaService, IConfigContratoBloqueioService configContratoBloqueioService, IMapper mapper)
        {
            _login = login;
            _modalidadeService = modalidadeService;
            _contratoService = contratoService;
            _configAvaliacaoFisicaService = configAvaliacaoFisicaService;
            _configCaixaService = configCaixaService;
            _configContratoBloqueioService = configContratoBloqueioService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Configurar([FromBody] OnboardingDto dto)
        {
            var loginResult = await _login.Login();

            var modalidade = _mapper.Map<Modalidade>(dto.ModalidadeDto);
            var modalidadeCriada = await _modalidadeService.Criar(modalidade);

            foreach (var modalidadeDto in dto.ContratoDto.Modalidades)
            {
                modalidadeDto.CodigoModalidade = modalidadeCriada.Id;
            }

            var contrato = _mapper.Map<Contrato>(dto.ContratoDto);
            var contratoCriado = await _contratoService.Criar(contrato);

            if (dto.ConfigAvaliacaoFisicaDto != null)
            {
                var configAvaliacaoFisica = _mapper.Map<ConfigAvaliacaoFisica>(dto.ConfigAvaliacaoFisicaDto);
                await _configAvaliacaoFisicaService.Configurar(configAvaliacaoFisica);
            }

            /*if (dto.ConfigCaixaDto != null)
            {
                var configCaixa = _mapper.Map<ConfigCaixa>(dto.ConfigCaixaDto);
                await _configCaixaService.Configurar(configCaixa);
            }

            if (dto.UsuarioRecebimentoCaixaDto != null)
            {
                var usuarioRecebimentoCaixa = _mapper.Map<UsuarioRecebimentoCaixa>(dto.UsuarioRecebimentoCaixaDto);
                await _configCaixaService.ConfigurarNotificarUsuarioFechamento(usuarioRecebimentoCaixa);
            }*/

            if (dto.ConfigContratoBloqueioDto != null)
            {
                var configContratoBloqueio = _mapper.Map<ConfigContratoBloqueio>(dto.ConfigContratoBloqueioDto);
                await _configContratoBloqueioService.Configurar(configContratoBloqueio);
            }

            return Ok(new
            {
                Modalidade = modalidadeCriada,
                Contrato = contratoCriado,
                Mensagem = "Onboarding realizado com sucesso!"
            });
        }
    }
}
