using Entra21.MiAuDota.Repositorio.Enum;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Entra21.MiAuDota.Servico.ViewModels.Animais
{
    public class AnimalViewModel : BaseViewModel
    {
        [Display(Name = "Raça")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MinLength(3, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(100, ErrorMessage = "{0} deve conter no máximo {1} caracteres")] 
        public string Raca { get; set; }

        [Display(Name = "Espécie")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public EspecieAnimal Especie { get; set; }

        [Display(Name = nameof(Sobre))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MinLength(10, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Sobre { get; set; }        

        [Display(Name = nameof(Idade))]
        [Required(ErrorMessage = "{0} deve ser preenchida")]
        public byte Idade { get; set; }

        [Display(Name = nameof(Peso))]
        [Required(ErrorMessage = "{0} deve ser preenchida")]
        public double Peso { get; set; }

        [Display(Name = nameof(Altura))]
        [Required(ErrorMessage = "{0} deve ser preenchida")]
        public double Altura { get; set; }

        [Display(Name = "É Castrado")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public bool Castrado { get; set; }

        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public GeneroAnimal Genero { get; set; }

        [Display(Name = "Id do Usuário")]
        public int? UsuarioId { get; set; }

        [Display(Name = "Id do Protetor")]
        public int? ProtetorId { get; set; }

        [Display(Name = "Data de adoção")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataAdocao { get; set; }

        [Display(Name = "Status na instituição")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        public StatusInstituicao Status { get; set; }

        [Display(Name = "Porte do Animal")]
        public PorteDoAnimal Porte { get; set; }

        public IFormFile? Arquivo { get; set; }
    }
}
