using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Enum;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;

namespace Entra21.MiAuDota.Servico.MapeamentoEntidades
{
    public class UsuarioMapeamentoEntidade : IUsuarioMapeamentoEntidade
    {
        public void AtualizarCampos(Usuario entity, UsuarioEditarViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Usuario ConstruirCom(UsuarioCadastrarViewModel viewModel)
        {
            return new Usuario
            {
                Nome = viewModel.Nome,
                Endereco = viewModel.Endereco,
                Celular = viewModel.Celular,
                Email = viewModel.Email,
                Cpf = viewModel.Cpf,
                Especialidade = viewModel.Especialidade,
                EhVoluntario = viewModel.EhVoluntario,
                EhUsuario = viewModel.EhUsuario,
                DataNascimento = viewModel.DataNascimento,

                StatusConta = (StatusConta)viewModel.StatusConta,

            };
        }
    }
}
