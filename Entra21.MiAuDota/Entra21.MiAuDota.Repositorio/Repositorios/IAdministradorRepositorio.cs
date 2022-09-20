using Entra21.MiAuDota.Repositorio.Entidades;

namespace Entra21.MiAuDota.Repositorio.Repositorios
{
    public interface IAdministradorRepositorio : IBaseRepositorio<Administrador>
    {
        Administrador Logon(string email, string senha);
    }
}