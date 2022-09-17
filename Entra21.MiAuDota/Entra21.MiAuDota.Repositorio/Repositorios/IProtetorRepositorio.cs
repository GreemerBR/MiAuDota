using Entra21.MiAuDota.Repositorio.Entidades;

namespace Entra21.MiAuDota.Repositorio.Repositorios
{
    public interface IProtetorRepositorio : IBaseRepositorio<Protetor>
    {

        Protetor Logon(string email, string senha);
    }
}