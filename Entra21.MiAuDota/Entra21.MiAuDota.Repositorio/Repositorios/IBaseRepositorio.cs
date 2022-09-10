using Entra21.MiAuDota.Repositorio.Entidades;

namespace Entra21.MiAuDota.Repositorio.Repositorios
{
    public interface IBaseRepositorio<T> where T : BaseEntity
    {
        bool Apagar(int id);
        T Cadastrar(T entity);
        void Editar(T entity);
        T? ObterPorId(int id);
        T Logon(string email, string senha);
        IList<T> ObterTodos();
        IList<T> ObterTodosComFiltro(string pesquisa);
    }
}