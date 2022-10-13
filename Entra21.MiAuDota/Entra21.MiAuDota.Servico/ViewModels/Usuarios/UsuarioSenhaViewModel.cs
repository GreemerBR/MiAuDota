namespace Entra21.MiAuDota.Servico.ViewModels.Usuarios
{
    public class UsuarioSenhaViewModel : BaseEditarViewModel<UsuarioViewModel>
    {
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
    }
}