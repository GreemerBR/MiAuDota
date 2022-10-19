using System.ComponentModel.DataAnnotations;

namespace Entra21.MiAuDota.Servico.ViewModels.Protetores
{
    public class ProtetorSenhaViewModel : BaseEditarViewModel<ProtetorViewModel>
    {
        public int Id { get; set; }

        [Display(Name = nameof(Senha))]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} deve ser preenchida")]
        [Compare("ConfirmarSenha")]
        public string Senha { get; set; }

        [Display(Name = nameof(ConfirmarSenha))]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} deve ser preenchida")]
        public string ConfirmarSenha { get; set; }
    }
}