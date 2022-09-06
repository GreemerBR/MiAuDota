using Entra21.MiAuDota.Repositorio.BancoDados;
using Entra21.MiAuDota.Repositorio.Entidades;

namespace Entra21.MiAuDota.Repositorio.Repositorios
{
    public class AnimalRepositorio : BaseRepositorio<Animal>
    {
        public AnimalRepositorio(MiAuDotaContexto contexto) : base(contexto)
        {
        }
    }
}
