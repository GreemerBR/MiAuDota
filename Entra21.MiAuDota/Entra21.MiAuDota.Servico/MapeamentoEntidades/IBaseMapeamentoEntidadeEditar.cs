using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels;

namespace Entra21.MiAuDota.Servico.MapeamentoEntidades
{
    public interface IBaseMapeamentoEntidadeEditar<TEntity, TUpdateViewModel, TUpdateStatusViewModel, TUpdateSenhaViewModel, TViewModel>
        where TEntity : BaseEntity
        where TUpdateViewModel : BaseEditarViewModel<TViewModel>
        where TUpdateStatusViewModel : BaseEditarViewModel<TViewModel>
        where TUpdateSenhaViewModel : BaseEditarViewModel<TViewModel>
        where TViewModel: BaseViewModel 
    {
        void AtualizarCampos(TEntity entity, TUpdateViewModel viewModel, string caminho = "");
        void AtualizarSenha(TEntity entity, TUpdateSenhaViewModel viewModel);
        void AtualizarStatus(TEntity entity, TUpdateStatusViewModel viewModel);
    }
}