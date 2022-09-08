namespace Entra21.MiAuDota.Servico.ViewModels
{
    public class BaseEditarViewModel<TViewModel>
        where TViewModel : BaseViewModel
    {
        public int Id { get; set; }
    }
}
