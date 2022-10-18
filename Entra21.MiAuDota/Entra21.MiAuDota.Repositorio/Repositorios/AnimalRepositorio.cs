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

        public override IList<Animal> ObterTodosComFiltro(string especie, string raca, byte idade, byte porte, byte genero)
        {
            var query = _contexto.Animais.AsQueryable();

            if (!string.IsNullOrEmpty(especie) && !string.IsNullOrEmpty(raca) && idade > 0 && porte > 0 && genero > 0)
                query = query.Where(x => x.Especie.Contains(especie) 
                || x.Raca.Contains(raca) 
                || x.Idade.Equals(idade) 
                || x.Porte.Equals(porte) 
                || x.Genero.Equals(genero));

            return query.ToList();
        }

        public List<Animal> ObterTodosPorProtetorId(int protetorId)
        {
            return _contexto.Animais.Where(x => x.ProtetorId == protetorId).ToList();
        }
    }
}
