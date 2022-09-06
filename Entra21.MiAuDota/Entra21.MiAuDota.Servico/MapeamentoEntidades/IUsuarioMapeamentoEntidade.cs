using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.MiAuDota.Servico.MapeamentoEntidades
{
    public interface IUsuarioMapeamentoEntidade
    {
        Usuario ConstruirCom(UsuarioCadastrarViewModel viewModel);
        void AtualizarCampos(Usuario veterinario, UsuarioEditarViewModel viewModel);
    }
}
