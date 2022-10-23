using System.ComponentModel.DataAnnotations;

namespace Entra21.MiAuDota.Servico.ViewModels.Administrador
{
    public class AdministradorViewModel : BaseViewModel
    {
        [Display(Name = nameof(Email))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "{0} deve ser em um formato válido")]
        public string Email { get; set; }

        [Display(Name = nameof(Senha))]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} deve ser preenchida")]
        [Compare("ConfirmarSenha")]
        public string Senha { get; set; }
    }
}