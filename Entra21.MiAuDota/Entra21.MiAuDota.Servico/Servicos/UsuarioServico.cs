using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public class UsuarioServico
        : BaseServico<Usuario, UsuarioCadastrarViewModel, UsuarioEditarViewModel, UsuarioViewModel, IUsuarioRepositorio, IUsuarioMapeamentoEntidade, IUsuarioMapeamentoViewModel>,
        IUsuarioServico
    {
        public UsuarioServico(
            IUsuarioRepositorio baseRepositorio, 
            IUsuarioMapeamentoEntidade baseMapeamentoEntidade, 
            IUsuarioMapeamentoViewModel mapeamentoViewModel) 
            : base(baseRepositorio, baseMapeamentoEntidade, mapeamentoViewModel)
        {
        }

        public Usuario? Logon(string email, string senha)
        {
            var entity = _baseRepositorio.Logon(email, senha);

            return entity;
        }
    }
}
