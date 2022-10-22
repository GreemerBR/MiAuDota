using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Enum;
using Entra21.MiAuDota.Servico.ViewModels.Animais;

namespace Entra21.MiAuDota.Servico.MapeamentoViewModel
{
	public class AnimalMapeamentoViewModel : IAnimalMapeamentoViewModel
    {
        public AnimalEditarViewModel ConstruirCom(Animal entity)
        {
            return new AnimalEditarViewModel
            {
                Nome = entity.Nome,
                Raca = entity.Raca,
                Especie = (EspecieAnimal)entity.Especie,
                Sobre = entity.Sobre,
                Foto = entity.Foto,
                Idade = (Byte)entity.Idade,
                Peso = (Double)entity.Peso,
                Altura = (Double)entity.Altura,
                Castrado = entity.Castrado,
                DataAdocao = entity.DataAdocao,
                Status = (StatusInstituicao)entity.Status,
                Usuario = entity.Usuario,
                ProtetorId = entity.ProtetorId,
                Protetor = entity.Protetor,
                Id = entity.Id,
                Genero = (GeneroAnimal)entity.Genero,
                Porte = (PorteDoAnimal)entity.Porte,
                DataAdocaoFormatada = entity.DataAdocao?.ToShortDateString() ?? string.Empty
            };
        }
        
        public AnimalEditarViewModel VizualizarCom(Animal entity)
        {
            return new AnimalEditarViewModel
            {
                Nome = entity.Nome,
                Raca = entity.Raca,
                Especie = (EspecieAnimal)entity.Especie,
                Sobre = entity.Sobre,
                Foto = entity.Foto,
                Idade = (Byte)entity.Idade,
                Peso = (Double)entity.Peso,
                Altura = (Double)entity.Altura,
                Castrado = entity.Castrado,
                DataAdocao = entity.DataAdocao,
                Status = (StatusInstituicao)entity.Status,
                Usuario = entity.Usuario,
                ProtetorId = entity.ProtetorId,
                Protetor = entity.Protetor,
                Id = entity.Id,
                Genero = (GeneroAnimal)entity.Genero,
                Porte = (PorteDoAnimal)entity.Porte,
                DataAdocaoFormatada = entity.DataAdocao?.ToShortDateString() ?? string.Empty
            };
        }
    }
}
