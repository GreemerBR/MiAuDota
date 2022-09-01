using Entra21.MiAuDota.Repositorio.BancoDados;
using Entra21.MiAuDota.Repositorio.Entidades;

namespace Entra21.MiAuDota.Repositorio.Repositorios
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
                using (MiAuDotaContexto contexto = new MiAuDotaContexto())
                {
                    contexto.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    contexto.SaveChanges();
                }

                return true;
            }
        }

        public T Cadastrar(T entity)
        {
            using (MiAuDotaContexto contexto = new MiAuDotaContexto())
            {
                contexto.Set<T>().Add(entity);
                contexto.SaveChanges();
            }

            return entity;
        }

        public void Editar(T entity)
        {
            using (MiAuDotaContexto contexto = new MiAuDotaContexto())
            {
                contexto.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public T? ObterPorId(int id)
        {
            T model = null;

            using (MiAuDotaContexto contexto = new MiAuDotaContexto())
            {
                model = contexto.Set<T>().Find(id);
            }

            return model;
        }

        public IList<T> ObterTodos()
        {
            IList<T> list = new List<T>();

            using (MiAuDotaContexto contexto = new MiAuDotaContexto())
            {
                list = contexto.Set<T>().ToList();
            }

            return list;
        }
    }
}
