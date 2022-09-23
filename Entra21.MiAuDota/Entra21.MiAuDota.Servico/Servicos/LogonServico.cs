using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.Autenticacao;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public class LogonServico : ILogonServico
    {
        private readonly ISessionManager _sessionManager;
        private readonly IAdministradorServico _administradorServico;
        private readonly IProtetorServico _protetorServico;
        private readonly IUsuarioServico _usuarioServico;

        public LogonServico(
            ISessionManager sessionManager,
            IAdministradorServico administradorServico,
            IProtetorServico protetorServico,
            IUsuarioServico usuarioServico)
        {
            _sessionManager = sessionManager;
            _administradorServico = administradorServico;
            _protetorServico = protetorServico;
            _usuarioServico = usuarioServico;
        }

        public string Logon(string email, string senha)
        {
            var administrador = _administradorServico.Logon(email, senha);
            if (administrador != null)
            {
                _sessionManager.Store(administrador);
                return "administradores";
            }

            var protetor = _protetorServico.Logon(email, senha);
            if (protetor != null)
            {
                _sessionManager.Store(protetor);
                return "protetores";
            }

            var usuario = _usuarioServico.Logon(email, senha);
            if (usuario != null)
            {
                _sessionManager.Store(usuario);
                return "usuarios";
            }

            return string.Empty;
        }
    }
}
