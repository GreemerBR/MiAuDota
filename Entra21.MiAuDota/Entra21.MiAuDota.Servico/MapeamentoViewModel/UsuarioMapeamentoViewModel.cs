using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;

namespace Entra21.MiAuDota.Servico.MapeamentoViewModel
{
    public class UsuarioMapeamentoViewModel : IUsuarioMapeamentoViewModel
    {
        public UsuarioEditarViewModel ConstruirCom(Usuario entity) =>
            new UsuarioEditarViewModel()
            {
                Nome = entity.Nome,
                Endereco = entity.Endereco,
                Celular = entity.Celular,
                Senha = entity.Senha,
                ConfirmarSenha = entity.ConfirmarSenha,
                Especialidade = entity.Especialidade,
                EhVoluntario = entity.EhVoluntario
            };
    }
}
