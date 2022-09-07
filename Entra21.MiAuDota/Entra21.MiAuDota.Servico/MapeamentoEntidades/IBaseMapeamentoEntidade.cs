using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels;

namespace Entra21.MiAuDota.Servico.MapeamentoEntidades
{
    public interface IBaseMapeamentoEntidade<T, C, E> where T : BaseEntity where C : BaseViewModel where E : BaseEditarViewModel
    {
        T ConstruirCom(C viewModel);
        void AtualizarCampos(T entity, E viewModel);
    }
}