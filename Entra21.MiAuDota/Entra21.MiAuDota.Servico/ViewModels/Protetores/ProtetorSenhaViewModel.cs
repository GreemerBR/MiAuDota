namespace Entra21.MiAuDota.Servico.ViewModels.Protetores
{
    public class ProtetorSenhaViewModel : BaseEditarViewModel<ProtetorViewModel>
    {
        public int Id { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
    }
}