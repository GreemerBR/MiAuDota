using System.ComponentModel.DataAnnotations;

namespace Entra21.MiAuDota.Servico.ViewModels.Protetores
{
    public class ProtetorViewModel : BaseViewModel
    {
        [Display(Name = "Endereço")]
        [MinLength(7, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public string? Endereco { get; set; }

        [Display(Name = nameof(Celular))]
        [MinLength(9, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(11, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public string? Celular { get; set; }

        [Display(Name = nameof(Telefone))]       
        [MinLength(8, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(15, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string? Telefone { get; set; }

        [Display(Name = nameof(Email))]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "{0} deve ser em um formato válido")]
        public string Email { get; set; }

        [Display(Name = nameof(Senha))]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} deve ser preenchida")]
        [Compare("ConfirmarSenha")]
        public string Senha { get; set; }

        [Display(Name = "Confirmar senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} deve ser preenchida")]
        public string ConfirmarSenha { get; set; }

        [Display(Name = "CPF")]
        public string? Cpf { get; set; }

        [Display(Name = "CNPJ")]
        public string? Cnpj { get; set; }

        [Display(Name = nameof(Pix))]
        public string? Pix { get; set; }

        [Display(Name = nameof(Facebook))]
        public string? Facebook { get; set; }

        [Display(Name = nameof(Instagram))]
        public string? Instagram { get; set; }

        [Display(Name = nameof(Sobre))]
        public string? Sobre { get; set; }
    }
}
