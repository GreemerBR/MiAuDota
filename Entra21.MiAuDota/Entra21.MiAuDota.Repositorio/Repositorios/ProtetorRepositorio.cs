using Entra21.MiAuDota.Repositorio.BancoDados;
using Entra21.MiAuDota.Repositorio.Entidades;

namespace Entra21.MiAuDota.Repositorio.Repositorios
{
    public class ProtetorRepositorio : BaseRepositorio<Protetor>
    {
        public ProtetorRepositorio(MiAuDotaContexto contexto) : base(contexto)
        {
        }
    }
}
