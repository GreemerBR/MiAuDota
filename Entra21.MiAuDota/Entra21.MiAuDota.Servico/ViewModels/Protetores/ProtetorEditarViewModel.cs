namespace Entra21.MiAuDota.Servico.ViewModels.Protetores
{
    public class ProtetorEditarViewModel : BaseEditarViewModel<ProtetorViewModel>
    {
        public string Endereco { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
        public string Pix { get; set; }
        public string Sobre { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public bool IsActive { get; set; }
    }
}
