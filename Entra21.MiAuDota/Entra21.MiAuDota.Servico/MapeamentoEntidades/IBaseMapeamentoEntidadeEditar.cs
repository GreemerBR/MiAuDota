using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels;

namespace Entra21.MiAuDota.Servico.MapeamentoEntidades
{
    public interface IBaseMapeamentoEntidadeEditar<TEntity, TUpdateViewModel, TViewModel>
        where TEntity : BaseEntity
        where TUpdateViewModel : BaseEditarViewModel<TViewModel>
        where TViewModel: BaseViewModel 
    {
        void AtualizarCampos(TEntity entity, TUpdateViewModel viewModel);
        void AtualizarSenha(TEntity entity, TUpdateViewModel viewModel);
        void AtualizarStatus(TEntity entity, TUpdateViewModel viewModel);
    }
}