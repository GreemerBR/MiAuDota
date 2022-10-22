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
            _contexto = contexto;
        }

        public List<Animal> ObterTodosPorProtetorId(int protetorId)
        {
            return _contexto.Animais.Where(x => x.ProtetorId == protetorId).ToList();
        }

        public override IList<Animal> ObterTodosComFiltro()
        {
            var query = _contexto.Animais.AsQueryable().Where(animal => animal.Status == Enum.StatusInstituicao.AptoParaAdocao);

            return query.ToList();
        }
    }
}
