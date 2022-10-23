using Entra21.MiAuDota.Repositorio.Enum;

namespace Entra21.MiAuDota.Repositorio.Entidades
{
    public class Animal : BaseEntity
    {
        public string Raca { get; set; }
        public string Sobre { get; set; }
        public string Foto { get; set; }
        public byte Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public bool Castrado { get; set; }
        public DateTime? DataAdocao { get; set; } 

        public EspecieAnimal Especie { get; set; }
        public GeneroAnimal Genero { get; set; }
        public StatusInstituicao Status { get; set; }
        public PorteDoAnimal Porte { get; set; }

        public int ProtetorId { get; set; }
        public Protetor Protetor { get; set; }
        public int? UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}    