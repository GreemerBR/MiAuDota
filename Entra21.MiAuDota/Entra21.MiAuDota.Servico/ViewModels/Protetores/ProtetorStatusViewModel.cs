namespace Entra21.MiAuDota.Servico.ViewModels.Protetores
{
    public class ProtetorStatusViewModel : BaseEditarViewModel<ProtetorViewModel>
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
    }
}