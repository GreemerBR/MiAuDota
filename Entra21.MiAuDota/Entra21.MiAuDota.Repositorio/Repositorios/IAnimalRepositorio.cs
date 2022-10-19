using Entra21.MiAuDota.Repositorio.Entidades;

namespace Entra21.MiAuDota.Repositorio.Repositorios
{
    public interface IAnimalRepositorio : IBaseRepositorio<Animal>
    {
        List<Animal> ObterTodosPorProtetorId(int protetorId);
    }
}