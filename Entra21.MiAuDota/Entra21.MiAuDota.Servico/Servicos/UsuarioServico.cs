using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public class UsuarioServico
        : BaseServico<Usuario, UsuarioCadastrarViewModel, UsuarioEditarViewModel, UsuarioViewModel, IUsuarioRepositorio, IUsuarioMapeamentoEntidade>,
        IUsuarioServico
    {
        public UsuarioServico(IUsuarioRepositorio baseRepositorio, 
            IUsuarioMapeamentoEntidade baseMapeamentoEntidade) 
            : base(baseRepositorio, baseMapeamentoEntidade)
        {
        }
    }
}
