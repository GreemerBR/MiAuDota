using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.Autenticacao;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public class LogonServico : ILogonServico
    {
        private readonly IAutenticacaoAdministrador _autenticadorAdministrador;
        private readonly IAutenticacaoProtetor _autenticadorProtetor;
        private readonly IAutenticacaoUsuario _autenticadorUsuario;
        private readonly IAdministradorServico _administradorServico;
        private readonly IProtetorServico _protetorServico;
        private readonly IUsuarioServico _usuarioServico;


        public string Logon(string email, string senha)
        {
            var administrador = _administradorServico.Logon(email, senha);
            if (administrador != null)
            {
                _autenticadorAdministrador.CriarSessao(administrador);
                return "administrador";
            }

            var protetor = _protetorServico.Logon(email, senha);
            if (protetor != null)
            {
                _autenticadorProtetor.CriarSessao(protetor);
                return "protetor";
            }

            var usuario = _usuarioServico.Logon(email, senha);
            if (usuario != null)
            {
                _autenticadorUsuario.CriarSessao(usuario);
                return "usuario";
            }

            return null;
        }
    }
}
