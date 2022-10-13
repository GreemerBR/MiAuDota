using Entra21.MiAuDota.Repositorio.Entidades;

namespace Entra21.MiAuDota.Repositorio.Repositorios
{
    public interface IBaseRepositorio<T> where T : BaseEntity
    {
        bool Apagar(int id);
        T Cadastrar(T entity);
        void EditarCampos(T entity);
        void EditarSenha(T entity);
        void EditarStatus(T entity);
        T? ObterPorId(int id);
        IList<T> ObterTodos();
        IList<T> ObterTodosComFiltro(string especie, string raca, byte idade, byte porte, byte genero);
    }
}