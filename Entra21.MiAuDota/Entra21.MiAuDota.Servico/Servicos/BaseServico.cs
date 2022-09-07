using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.ViewModels;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public class BaseServico<T, C, E> : IBaseServico<T, C, E> where T : BaseEntity where C : BaseViewModel where E : BaseEditarViewModel
    {
        private readonly IBaseRepositorio<T> _baseRepositorio;
        private readonly IBaseMapeamentoEntidade<T, C, E> _baseMapeamentoEntidade;

        public BaseServico(
            IBaseRepositorio<T> baseRepositorio,
            IBaseMapeamentoEntidade<T, C, E> baseMapeamentoEntidade)
        {
            _baseRepositorio = baseRepositorio;
            _baseMapeamentoEntidade = baseMapeamentoEntidade;
        }

        public bool Apagar(int id)
        {
            _baseRepositorio.Apagar(id);

            return true;
        }

        public T Cadastrar(C viewModel)
        {
            var entity = _baseMapeamentoEntidade.ConstruirCom(viewModel);

            _baseRepositorio.Cadastrar(entity);

            return entity;
        }

        public bool Editar(E viewModel)
        {
            T entity = _baseRepositorio.ObterPorId(viewModel.Id);

            if (entity == null)
                return false;

            _baseMapeamentoEntidade.AtualizarCampos(entity, viewModel);

            _baseRepositorio.Editar(entity);

            return true;
        }

        public T? ObterPorId(int id)
        {
            var entity = _baseRepositorio.ObterPorId(id);

            return entity;
        }

        public IList<T> ObterTodos()
        {
            var list = _baseRepositorio.ObterTodos();

            return list;
        }
    }
}
