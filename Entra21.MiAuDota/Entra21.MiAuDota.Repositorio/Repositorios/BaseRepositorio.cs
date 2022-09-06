using Entra21.MiAuDota.Repositorio.BancoDados;
using Entra21.MiAuDota.Repositorio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Entra21.MiAuDota.Repositorio.Repositorios
{
    public abstract class BaseRepositorio<T> : IRepositorio<T> where T : BaseModel
    {
        private readonly MiAuDotaContexto _contexto;

        public BaseRepositorio(MiAuDotaContexto contexto)
        {
            _contexto = contexto;
        }

        public bool Apagar(int id)
        {
            var entity = ObterPorId(id);

            if (entity == null)
                return false;

            _contexto.Entry<T>(entity).State = EntityState.Deleted;
            _contexto.SaveChanges();


            return true;

        }

        public T Cadastrar(T entity)
        {
            _contexto.Set<T>().Add(entity);
            _contexto.SaveChanges();

            return entity;
        }

        public void Editar(T entity)
        {
            _contexto.Entry<T>(entity).State = EntityState.Modified;
        }

        public T? ObterPorId(int id)
        {
            T model = null;

            model = _contexto.Set<T>().Find(id);

            return model;
        }

        public IList<T> ObterTodos()
        {
            IList<T> list = new List<T>();

            list = _contexto.Set<T>().ToList();

            return list;
        }
    }
}