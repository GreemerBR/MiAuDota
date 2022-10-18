using Entra21.MiAuDota.Repositorio.Enum;
using Microsoft.AspNetCore.Http;

namespace Entra21.MiAuDota.Servico.ViewModels.Animais
{
    public class AnimalEditarViewModel : BaseEditarViewModel<AnimalViewModel>
    {
        public string Raca { get; set; }
        public string Especie { get; set; }
        public string Sobre { get; set; }
        public string Vacinas { get; set; }
        public string Alergias { get; set; }
        public string? OutrasInformacoesMedicas { get; set; }
        public IFormFile? Arquivo { get; set; }
        public byte Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public bool Castrado { get; set; }

        public DateTime? DataAdocao { get; set; }

        public GeneroAnimal Genero { get; set; }
        public StatusInstituicao Status { get; set; }
        public PorteDoAnimal Porte { get; set; }

        public int? UsuarioId { get; set; }

        public string? Foto { get; set; }
    }
}
