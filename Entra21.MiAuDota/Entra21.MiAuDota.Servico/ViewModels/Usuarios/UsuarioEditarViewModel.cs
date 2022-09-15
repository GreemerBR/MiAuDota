using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Enum;

namespace Entra21.MiAuDota.Servico.ViewModels.Usuarios
{
    public class UsuarioEditarViewModel : BaseEditarViewModel<UsuarioViewModel>
    {
        public string? Endereco { get; set; }
        public string? Celular { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
        public string? Especialidade { get; set; }
        public bool? EhVoluntario { get; set; }

        public StatusConta? StatusConta { get; set; }
    }
}
