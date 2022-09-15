using System.ComponentModel.DataAnnotations;

namespace Entra21.MiAuDota.Servico.ViewModels.Usuarios
{
    public abstract class UsuarioViewModel : BaseViewModel
    {
        [Display(Name = "Endereço")]
        [MinLength(7, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Endereco { get; set; }

        [Display(Name = nameof(Celular))]
        [MinLength(9, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(11, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Celular { get; set; }

        [Display(Name = nameof(Email))]
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
        public string Cpf { get; set; }

        [Display(Name = nameof(Especialidade))]
        [MinLength(5, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string? Especialidade { get; set; }

        [Display(Name = "É voluntário")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public bool EhVoluntario { get; set; }

        [Display(Name = "É usuário")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public bool EhUsuario { get; set; }

        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", NullDisplayText = "{0} deve ser preenchido no formato '00/00/0000'")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Status da conta")]
        public byte StatusConta { get; set; }
    }
}
