using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels;

namespace Entra21.MiAuDota.Servico.MapeamentoEntidades
{
    public interface IBaseMapeamentoEntidade<TEntity, TCreateViewModel, TUpdateViewModel, TUpdateStatusViewModel, TUpdateSenhaViewModel, TViewModel>
        : IBaseMapeamentoEntidadeEditar<TEntity, TUpdateViewModel, TUpdateStatusViewModel, TUpdateSenhaViewModel, TViewModel>
        where TEntity : BaseEntity 
        where TCreateViewModel : BaseViewModel
        where TUpdateViewModel : BaseEditarViewModel<TViewModel>
        where TUpdateStatusViewModel : BaseEditarViewModel<TViewModel>
        where TUpdateSenhaViewModel : BaseEditarViewModel<TViewModel>
        where TViewModel: BaseViewModel
    {
        TEntity ConstruirCom(TCreateViewModel viewModel);
    }
}