namespace Entra21.MiAuDota.Servico.ViewModels
{
    public class BaseEditarViewModel<TViewModel> : BaseViewModel
        where TViewModel : BaseViewModel
    {
        public int Id { get; set; }
    }
}
