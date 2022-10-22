using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Enum;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Entra21.MiAuDota.Servico.ViewModels.Animais
{
    public class AnimalEditarViewModel : BaseEditarViewModel<AnimalViewModel>
    {
        public string Raca { get; set; }
        public string Sobre { get; set; }
        public IFormFile? Arquivo { get; set; }
        public byte Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public bool Castrado { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataAdocao { get; set; }

        public EspecieAnimal Especie { get; set; }
        public GeneroAnimal Genero { get; set; }
        public StatusInstituicao Status { get; set; }
        public PorteDoAnimal Porte { get; set; }

        public Usuario? Usuario { get; set; }

        public Protetor? Protetor { get; set; }
        public int? ProtetorId { get; set; }

        public string? Foto { get; set; }

        public string? DataAdocaoFormatada { get; set; }
    }
}
