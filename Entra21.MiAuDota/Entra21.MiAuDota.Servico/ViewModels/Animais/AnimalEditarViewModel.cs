using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Enum;

namespace Entra21.MiAuDota.Servico.ViewModels.Animais
{
    public class AnimalEditarViewModel : BaseEditarViewModel<AnimalViewModel>
    {
        public string Sobre { get; set; }
        public string Vacinas { get; set; }
        public string Alergias { get; set; }
        public string? OutrasInformacoesMedicas { get; set; }
        public string Foto { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public bool Castrado { get; set; }
        public DateTime? DataAdocao { get; set; }
        public StatusInstituicao Status { get; set; }
        public int UsuarioId { get; set; }
    }
}
