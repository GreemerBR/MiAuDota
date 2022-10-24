using System.ComponentModel.DataAnnotations;

namespace Entra21.MiAuDota.Servico.ViewModels
{
    public abstract class LogonViewModel
    {
        [Display(Name = nameof(Email))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "{0} deve ser em um formato válido")]
        public string Email { get; set; }

        [Display(Name = nameof(Senha))]
        [Required(ErrorMessage = "{0} deve ser preenchida")]
        public string Senha { get; set; }
    }
}