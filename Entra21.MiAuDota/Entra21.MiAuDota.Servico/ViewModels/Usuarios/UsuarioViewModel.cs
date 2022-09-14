using System.ComponentModel.DataAnnotations;

namespace Entra21.MiAuDota.Servico.ViewModels.Usuarios
{
    public abstract class UsuarioViewModel : BaseViewModel
    {
        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MinLength(7, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Endereco { get; set; }

        [Display(Name = nameof(Celular))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [RegularExpression(@"^\d[0-9]{2}+9\d[0-9]{4}\+-\d[0-9]{4}$", ErrorMessage = "{0} deve ser preenchido no formato '(00)90000-0000'")]
        public string Celular { get; set; }

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
        [Required(ErrorMessage = "{0} deve ser preenchido")]
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
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", NullDisplayText = "{0} deve ser preenchido no formato '00/00/0000'")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Status da conta")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public byte StatusConta { get; set; }
    }
}
