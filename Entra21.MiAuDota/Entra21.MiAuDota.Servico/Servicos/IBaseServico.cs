using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public interface IBaseServico<T, C, E> where T : BaseEntity where C : BaseViewModel where E : BaseEditarViewModel
    {
        T Cadastrar(C viewModel);
        bool Apagar(int id);
        bool Editar(E viewModel);
        T? ObterPorId(int id);
        IList<T> ObterTodos();
    }
}