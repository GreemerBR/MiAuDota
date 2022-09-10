using Entra21.MiAuDota.Repositorio.BancoDados;
using Entra21.MiAuDota.Repositorio.Entidades;

namespace Entra21.MiAuDota.Repositorio.Repositorios
{
    public class AnimalRepositorio 
        : BaseRepositorio<Animal>,
        IAnimalRepositorio
    {
        private readonly MiAuDotaContexto _contexto;

        public AnimalRepositorio(MiAuDotaContexto contexto) : base(contexto)
        {
        }

        public override IList<Animal> ObterTodosComFiltro(string pesquisa)
        {
            var query = _contexto.Animais.AsQueryable();

            if (!string.IsNullOrEmpty(pesquisa))
                query = query.Where(x => x.Especie.Contains(pesquisa) || x.Raca.Contains(pesquisa));

            return query.ToList();
        }
    }
}
