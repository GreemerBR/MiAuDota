using Entra21.TrabalhoFinal.Repositorio.Entidades;

namespace Entra21.TrabalhoFinal.Repositorio.Repositorios
{
    public interface IRepositorio<T> where T : BaseModel
    {
        bool Apagar(int id);
        T Cadastrar(T entity);
        void Editar (T entity);
        T? ObterPorId(int id);
        IList<T> ObterTodos();
    }
}