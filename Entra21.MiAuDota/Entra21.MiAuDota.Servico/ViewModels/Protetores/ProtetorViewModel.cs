using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Entra21.MiAuDota.Servico.ViewModels.Protetores
{
    public class ProtetorViewModel : BaseViewModel
    {

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MinLength(7, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Endereco { get; set; }

        [Display(Name = nameof(Celular))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [RegularExpression(@"^(\d[0-9]{2})\9\d[0-9]{4}-\d[0-9]{4}$", ErrorMessage = "{0} deve ser preenchido no formato '(00)90000-0000'")]
        public string Celular { get; set; }
        
        [Display(Name = nameof(Telefone))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [RegularExpression(@"^(\d[0-9]{2})\d[0-9]{4}-\d[0-9]{4}$", ErrorMessage = "{0} deve ser preenchido no formato '(00)90000-0000'")]
        public string Telefone { get; set; }

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
        [RegularExpression(@"^\d[0-9]{3}.\d[0-9]{3}.\d[0-9]{3}-\d[0-9]{2}$", ErrorMessage = "{0} deve ser preenchido no formato '000.000.000-00'")]
        public string Cpf { get; set; }

        [Display(Name = "CNPJ")]
        [RegularExpression(@"^\d[0-9]{2}.\d[0-9]{3}.\d[0-9]{3}\/0001-\d[0-9]{2}$", ErrorMessage = "{0} deve ser preenchido no formato '000.000.000-00'")]
        public string Cnpj { get; set; }

        [Display(Name = nameof(Especialidade))]
        [MinLength(5, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string? Especialidade { get; set; }

        [Display(Name = nameof(Pix))]
        public string Pix { get; set; }
        
        [Display(Name = nameof(Facebook))]
        public string Facebook { get; set; }
        
        [Display(Name = nameof(Instagram))]
        public string Instagram { get; set; }
        
        [Display(Name = nameof(Sobre))]
        public string Sobre { get; set; }

        [Display(Name = "É Protetor")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public bool EhUsuario { get; set; }

        public byte StatusConta { get; set; }
    }
}
