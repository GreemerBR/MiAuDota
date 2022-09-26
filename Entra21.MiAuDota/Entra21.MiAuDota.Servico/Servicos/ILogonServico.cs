using Entra21.MiAuDota.Repositorio.Entidades;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public interface ILogonServico
    {
        string Logon(string email, string senha);
        void Logout<TUserBase>() where TUserBase : UsuarioBase;
    }
}