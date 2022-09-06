using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public interface IUsuarioServico
    {
        Usuario Cadastrar(UsuarioCadastrarViewModel viewModel);
        bool Apagar(int id);
        bool Editar(UsuarioEditarViewModel viewModel);
        Usuario? ObterPorId(int id);
        IList<Usuario> ObterTodos(string pesquisa);

    }
}
