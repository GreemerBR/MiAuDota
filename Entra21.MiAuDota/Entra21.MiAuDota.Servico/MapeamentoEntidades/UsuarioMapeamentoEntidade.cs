using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Enum;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;

namespace Entra21.MiAuDota.Servico.MapeamentoEntidades
{
    public class UsuarioMapeamentoEntidade : IUsuarioMapeamentoEntidade
    {
        public void AtualizarCampos(Usuario entity, UsuarioEditarViewModel viewModel)
        {
            entity.Endereco = viewModel.Endereco;
            entity.Celular = viewModel.Celular;
            entity.Senha = viewModel.Senha;
            entity.ConfirmarSenha = viewModel.ConfirmarSenha;
            entity.Especialidade = viewModel.Especialidade;
            entity.EhVoluntario = viewModel.EhVoluntario;
            entity.StatusConta = viewModel.StatusConta;
        }

        public Usuario ConstruirCom(UsuarioCadastrarViewModel viewModel)
        {
            return new Usuario
            {
                Nome = viewModel.Nome,
                Endereco = viewModel.Endereco,
                Celular = viewModel.Celular,
                Email = viewModel.Email,
                Senha = viewModel.Senha,
                ConfirmarSenha = viewModel.ConfirmarSenha,
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
