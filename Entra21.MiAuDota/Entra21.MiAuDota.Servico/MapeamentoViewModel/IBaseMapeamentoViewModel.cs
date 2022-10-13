using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels;

namespace Entra21.MiAuDota.Servico.MapeamentoViewModel
{
    public interface IBaseMapeamentoViewModel<TEntity, TUpdateViewModel, TUpdateStatusViewModel, TUpdateSenhaViewModel, TViewModel>
        where TEntity : BaseEntity
        where TUpdateViewModel : BaseEditarViewModel<TViewModel>
        where TViewModel : BaseViewModel 
    {
        TUpdateViewModel ConstruirCom(TEntity entity);
    }
}
