using Entra21.MiAuDota.Repositorio.Entidades;

namespace Entra21.MiAuDota.Servico.Autenticacao
{
    public interface ISessionManager
    {
        void Store<TUserBase>(TUserBase userBase) where TUserBase : UsuarioBase;
        TUserBase GetUser<TUserBase>() where TUserBase : UsuarioBase;
        void Logout<TUserBase>() where TUserBase : UsuarioBase;
    }
}