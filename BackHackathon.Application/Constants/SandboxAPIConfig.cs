namespace BackHackathon.Application.Constants
{
    public static class SandboxApiConfig
    {
        public static class BaseUrl
        {
            public const string ApiBase = "https://api.sandbox.appnext.fit/api";
        }
        
        public static class Endpoints
        {
            public const string EnumRecuperarTodos = $"{BaseUrl.ApiBase}/Enum/RecuperarTodos";
            public const string UsuarioRecuperarAmbienteUsuario = $"{BaseUrl.ApiBase}/usuario/RecuperarAmbienteUsuario";
            public const string Token = $"{BaseUrl.ApiBase}/token";

            public const string RecuperarRecursos = $"{BaseUrl.ApiBase}/RecursoSistema/RecuperarRecursos";
            public const string PerfilAcessoRecuperarPermissoesUsuarioLogado = $"{BaseUrl.ApiBase}/PerfilAcesso/RecuperarPermissoesUsuarioLogado";

            public const string InserirModalidade = $"{BaseUrl.ApiBase}/Modalidade/Inserir";
            public const string InserirContrato = $"{BaseUrl.ApiBase}/ContratoBase";
            public const string ConfigAvaliacaoFisica = $"{BaseUrl.ApiBase}/ConfigAvaliacaoFisica";

            public const string ConfigCaixa = $"{BaseUrl.ApiBase}/ConfigCaixa";
            public const string ConfigCaixaNotifUsuarioFechamento = $"{BaseUrl.ApiBase}/ConfigCaixaNotifUsuarioFechamento/Inserir";
            public const string ConfigContratoBloqueio = $"{BaseUrl.ApiBase}/ConfigContratoBloqueio";
        }

        public static class Headers
        {
            public const string CodigoUnidade = "CodigoUnidade";
            public const string CodigoUsuario = "CodigoUsuario";
        }
    }
}