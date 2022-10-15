using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;

namespace Entra21.MiAuDota.Servico.MapeamentoEntidades
{
    public class ProtetorMapeamentoEntidade : IProtetorMapeamentoEntidade
    {
        public void AtualizarCampos(Protetor entity, ProtetorEditarViewModel viewModel)
        {
            entity.Endereco = viewModel.Endereco;
            entity.Celular = viewModel.Celular;
            entity.Telefone = viewModel.Telefone;
            entity.Pix = viewModel.Pix;
            entity.Sobre = viewModel.Sobre;
            entity.Instagram = viewModel.Instagram;
            entity.Facebook = viewModel.Facebook;
        }

        public void AtualizarSenha(Protetor entity, ProtetorSenhaViewModel viewModel)
        {
            
            entity.Senha = viewModel.Senha;
            entity.ConfirmarSenha = viewModel.ConfirmarSenha;
        }

        public void AtualizarStatus(Protetor entity, ProtetorStatusViewModel viewModel)
        {
            entity.IsActive = viewModel.IsActive;
        }

        public Protetor ConstruirCom(ProtetorCadastrarViewModel viewModel, string? caminho)
        {
            return new Protetor
            {
                Nome = viewModel.Nome,
                Cpf = viewModel.Cpf,
                Cnpj = viewModel.Cnpj,
                Endereco = viewModel.Endereco,
                Celular = viewModel.Celular,
                Telefone = viewModel.Telefone,
                Email = viewModel.Email,
                Senha = viewModel.Senha,
                ConfirmarSenha = viewModel.ConfirmarSenha,
                Pix = viewModel.Pix,
                Sobre = viewModel.Sobre,
                Instagram = viewModel.Instagram,
                Facebook = viewModel.Facebook,
                IsActive = false,
            };
        }
    }
}
