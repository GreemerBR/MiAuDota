using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public interface IBaseServico<TEntity, TCreateViewModel, TUpdateViewModel, TViewModel> 
        where TEntity : BaseEntity 
        where TCreateViewModel : BaseViewModel 
        where TUpdateViewModel : BaseEditarViewModel<TViewModel>
        where TViewModel : BaseViewModel
    {
        TEntity Cadastrar(TCreateViewModel viewModel);
        bool Apagar(int id);
        bool Editar(TUpdateViewModel viewModel);
        TEntity? ObterPorId(int id);
        IList<TEntity> ObterTodos();
    }
}