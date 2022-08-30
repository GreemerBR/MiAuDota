using Entra21.TrabalhoFinal.Repositorio.Entidades;

namespace Entra21.TrabalhoFinal.Repositorio.Repositorios
{
    public class BaseRepositorio<T> : IRepositorio<T> where T : BaseModel
    {
        private readonly NomeIndefinidoContexto = _contexto;

        public bool Apagar(int id)
        {
            using
        }

        public T Cadastrar(T entity)
        {
            throw new NotImplementedException();
        }

        public void Editar(T entity)
        {
            throw new NotImplementedException();
        }

        public T? ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
