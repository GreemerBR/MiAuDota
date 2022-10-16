using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;

namespace Entra21.MiAuDota.Servico.MapeamentoEntidades
{
    public class UsuarioMapeamentoEntidade : IUsuarioMapeamentoEntidade
    {
        public void AtualizarCampos(Usuario entity, UsuarioEditarViewModel viewModel)
        {
            entity.Nome = viewModel.Nome;
            entity.Endereco = viewModel.Endereco;
            entity.Celular = viewModel.Celular;
            entity.Especialidade = viewModel.Especialidade;
            entity.EhVoluntario = viewModel.EhVoluntario;
        }

        public void AtualizarSenha(Usuario entity, UsuarioSenhaViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public void AtualizarStatus(Usuario entity, UsuarioEditarViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Usuario ConstruirCom(UsuarioCadastrarViewModel viewModel, string? caminho)
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
                DataNascimento = viewModel.DataNascimento,
                IsActive = true,
            };
        }
    }
}
