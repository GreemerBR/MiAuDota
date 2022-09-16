using System.ComponentModel.DataAnnotations;

namespace Entra21.MiAuDota.Servico.ViewModels.Protetores
{
    public class ProtetorViewModel : BaseViewModel
    {
        [Display(Name = "Endereço")]
        [MinLength(7, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string? Endereco { get; set; }

        [Display(Name = nameof(Celular))]
        [MinLength(9, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(11, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string? Celular { get; set; }

        [Display(Name = nameof(Telefone))]       
        [MinLength(8, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(10, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string? Telefone { get; set; }

        [Display(Name = nameof(Email))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "{0} deve ser em um formato válido")]
        public string Email { get; set; }

        [Display(Name = nameof(Senha))]
        [Required(ErrorMessage = "{0} deve ser preenchida")]
        public string Senha { get; set; }

        [Display(Name = "Confirmar senha")]
        [Required(ErrorMessage = "{0} deve ser preenchida")]
        public string ConfirmarSenha { get; set; }

        [Display(Name = "CPF")]
        public string? Cpf { get; set; }

        [Display(Name = "CNPJ")]
        public string? Cnpj { get; set; }

        [Display(Name = nameof(Especialidade))]
        [MinLength(5, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string? Especialidade { get; set; }

        [Display(Name = nameof(Pix))]
        public string? Pix { get; set; }

        [Display(Name = nameof(Facebook))]
        public string? Facebook { get; set; }

        [Display(Name = nameof(Instagram))]
        public string? Instagram { get; set; }

        [Display(Name = nameof(Sobre))]
        public string? Sobre { get; set; }

        [Display(Name = "É Protetor")]
        public bool EhProtetor { get; set; }

        [Display(Name = "Status da conta")]
        public byte StatusConta { get; set; }
    }
}
