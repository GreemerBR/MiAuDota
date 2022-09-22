namespace Entra21.MiAuDota.Servico.Servicos
{
    public class LogonServico : ILogonServico
    {
        private readonly IAdministradorServico _administradorServico;
        private readonly IProtetorServico _protetorServico;
        private readonly IUsuarioServico _usuarioServico;

        public string Logon(string email, string senha)
        {
            var administrador = _administradorServico.Logon(email, senha);
            if (administrador != null)
                return "Administrador";

            var protetor = _protetorServico.Logon(email, senha);
            if (protetor != null)
                return "Protetores";

            var usuario = _usuarioServico.Logon(email, senha);
            if (usuario != null)
                return "Usuarios";

            return "Publico";
        }
    }
}
