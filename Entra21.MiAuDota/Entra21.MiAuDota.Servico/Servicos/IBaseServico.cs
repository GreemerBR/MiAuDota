using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.ViewModels;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public interface IBaseServico<TEntity, TBaseModel, TCreateViewModel, TUpdateViewModel, TViewModel, TRepositorio, TMapeamentoEntidade, TMapeamentoViewModel>
        where TEntity : BaseEntity
        where TBaseModel : UsuarioBase
        where TCreateViewModel : BaseViewModel
        where TUpdateViewModel : BaseEditarViewModel<TViewModel>
        where TViewModel : BaseViewModel
        where TRepositorio : IBaseRepositorio<TEntity>
        where TMapeamentoEntidade : IBaseMapeamentoEntidade<TEntity, TCreateViewModel, TUpdateViewModel, TViewModel>
        where TMapeamentoViewModel : IBaseMapeamentoViewModel<TEntity, TUpdateViewModel, TViewModel>

    {
        TEntity Cadastrar(TCreateViewModel viewModel);
        bool Apagar(int id);
        bool Editar(TUpdateViewModel viewModel);
        TUpdateViewModel? ObterPorId(int id);
        IList<TEntity> ObterTodos();
        IList<TEntity> ObterTodosComFiltro(string pesquisa);
    }
}