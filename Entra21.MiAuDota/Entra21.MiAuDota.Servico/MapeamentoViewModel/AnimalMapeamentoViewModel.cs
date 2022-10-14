using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Enum;
using Entra21.MiAuDota.Servico.ViewModels.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Especie = entity.Especie,
                Sobre = entity.Sobre,
                Vacinas = entity.Vacinas,
                Alergias = entity.Alergias,
                OutrasInformacoesMedicas = entity.OutrasInformacoesMedicas,
                Foto = entity.Foto,
                Idade = (Byte)entity.Idade,
                Peso = (Double)entity.Peso,
                Altura = (Double)entity.Altura,
                Castrado = entity.Castrado,
                DataAdocao = entity.DataAdocao,
                Status = (StatusInstituicao)entity.Status,
                UsuarioId = (int)entity.UsuarioId
            };
        }
    }
}
