using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Enum;
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
            entity.Senha = viewModel.Senha;
            entity.ConfirmarSenha = viewModel.ConfirmarSenha; ;
            entity.Pix = viewModel.Pix;
            entity.Sobre = viewModel.Sobre;
            entity.Instagram = viewModel.Instagram;
            entity.Facebook = viewModel.Facebook;
        }

        public Protetor ConstruirCom(ProtetorCadastrarViewModel viewModel)
        {
            return new Protetor
            {
                Nome = viewModel.Nome,
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
                StatusConta = false,
            };
        }
    }
}
