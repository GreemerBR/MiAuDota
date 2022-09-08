using Entra21.MiAuDota.Repositorio.BancoDados;
using Entra21.MiAuDota.Repositorio.Entidades;

namespace Entra21.MiAuDota.Repositorio.Repositorios
{
    public class UsuarioRepositorio
        : BaseRepositorio<Usuario>,
        IUsuarioRepositorio
    {
        public UsuarioRepositorio(MiAuDotaContexto contexto) : base(contexto)
        {
        }
    }
}
