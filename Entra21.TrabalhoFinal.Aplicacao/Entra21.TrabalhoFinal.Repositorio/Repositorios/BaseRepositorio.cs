using Entra21.TrabalhoFinal.Repositorio.BancoDados;
using Entra21.TrabalhoFinal.Repositorio.Entidades;

namespace Entra21.TrabalhoFinal.Repositorio.Repositorios
{
    public class BaseRepositorio<T> : IRepositorio<T> where T : BaseModel
    {
        //private readonly NomeIndefinidoContexto _contexto;

        public bool Apagar(int id)
        {
            var entity = ObterPorId(id);

            if (entity == null)
            {
                return false;
            }
            else
            {
                using (NomeIndefinidoContexto contexto = new NomeIndefinidoContexto())
                {
                    contexto.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    contexto.SaveChanges();
                }

                return true;
            }
        }

        public T Cadastrar(T entity)
        {
            using (NomeIndefinidoContexto contexto = new NomeIndefinidoContexto())
            {
                contexto.Set<T>().Add(entity);
                contexto.SaveChanges();
            }

            return entity;
        }

        public void Editar(T entity)
        {
            using (NomeIndefinidoContexto contexto = new NomeIndefinidoContexto())
            {
                contexto.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public T? ObterPorId(int id)
        {
            T model = null;

            using (NomeIndefinidoContexto contexto = new NomeIndefinidoContexto())
            {
                model = contexto.Set<T>().Find(id);
            }

            return model;
        }

        public IList<T> ObterTodos()
        {
            IList<T> list = new List<T>();

            using (NomeIndefinidoContexto contexto = new NomeIndefinidoContexto())
            {
                list = contexto.Set<T>().ToList();
            }

            return list;
        }
    }
}
