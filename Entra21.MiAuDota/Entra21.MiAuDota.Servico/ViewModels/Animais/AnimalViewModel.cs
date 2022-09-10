using System.ComponentModel.DataAnnotations;

namespace Entra21.MiAuDota.Servico.ViewModels.Animais
{
    public class AnimalViewModel : BaseViewModel
    {
        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MinLength(2, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Endereco { get; set; }

        [Display(Name = "Raça")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MinLength(3, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} caracteres")] 
        public string Raca { get; set; }

        [Display(Name = "Espécie")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MinLength(3, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Especie { get; set; }

        [Display(Name = nameof(Sobre))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MinLength(10, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Sobre { get; set; }

        [Display(Name = nameof(Vacinas))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MaxLength(200, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Vacinas { get; set; }

        [Display(Name = nameof(Alergias))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MaxLength(200, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Alergias { get; set; }

        [Display(Name = nameof(Foto))]
        [Required(ErrorMessage = "{0} deve ser enviada")]
        public string Foto { get; set; }

        [Display(Name = nameof(Idade))]
        [Required(ErrorMessage = "{0} deve ser preenchida")]
        [RegularExpression(@"^(\d[0-9]{1,2})$", ErrorMessage = "{0} deve ser preenchida")]
        public int Idade { get; set; }

        [Display(Name = nameof(Peso))]
        [Required(ErrorMessage = "{0} deve ser preenchida")]
        [RegularExpression(@"^(\d[0-9]{1,2},\d[0-9]{1,2})$", ErrorMessage = "{0} deve ser preenchida")]
        public double Peso { get; set; }

        [Display(Name = nameof(Altura))]
        [Required(ErrorMessage = "{0} deve ser preenchida")]
        [RegularExpression(@"^(\d[0-9]{1,2},\d[0-9]{1,2})$", ErrorMessage = "{0} deve ser preenchida")]
        public double Altura { get; set; }

        [Display(Name = "É Castrado")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public bool Castrado { get; set; }

        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public byte Genero { get; set; }

        [Display(Name = "Id do Usuário")]
        public int UsuarioId { get; set; }

        [Display(Name = "Id do Protetor")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public int ProtetorId { get; set; }

        [Display(Name = "Data de adoção")]
        [RegularExpression(@"\(d[0-3]{1})\(d[0-9]{1})/\(d[0-1]{1})\(d[0-9]{1})/\(d[0-2]{1})\(d[0-9]{3})", ErrorMessage = "{0} deve ser preenchido no formato '00/00/0000'")]
        public DateTime DataAdocao { get; set; }

        [Display(Name = "Status na instituíção")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public byte Status { get; set; }


        [Display(Name = "Outras informacoesMedicas")]
        public string OutrasInformacoesMedicas { get; set; }
    }
}
