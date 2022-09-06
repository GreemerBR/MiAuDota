using System.ComponentModel.DataAnnotations;

namespace Entra21.MiAuDota.Servico.ViewModels
{
    public abstract class BaseViewModel
    {
        [Display(Name = nameof(Nome))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MinLength(4, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(50, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Nome { get; set; }
    }
}
