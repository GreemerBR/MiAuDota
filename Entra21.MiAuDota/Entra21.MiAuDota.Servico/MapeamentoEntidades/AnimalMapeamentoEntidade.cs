using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Enum;
using Entra21.MiAuDota.Servico.ViewModels.Animais;

namespace Entra21.MiAuDota.Servico.MapeamentoEntidades
{
    public class AnimalMapeamentoEntidade : IAnimalMapeamentoEntidade
    {
        public void AtualizarCampos(Animal entity, AnimalEditarViewModel viewModel)
        {
            entity.Sobre = viewModel.Sobre;
            entity.Vacinas = viewModel.Vacinas;
            entity.Alergias = viewModel.Alergias;
            entity.OutrasInformacoesMedicas = viewModel.OutrasInformacoesMedicas;
            entity.Foto = viewModel.Foto;
            entity.Idade = viewModel.Idade;
            entity.Peso = viewModel.Peso;
            entity.Altura = viewModel.Altura;
            entity.Castrado = viewModel.Castrado;
            entity.DataAdocao = viewModel.DataAdocao;
            entity.Genero = viewModel.Genero;
            entity.Status = viewModel.Status;
            entity.UsuarioId = viewModel.UsuarioId;
        }

        public Animal ConstruirCom(AnimalCadastrarViewModel viewModel)
        {
            return new Animal
            {
                Nome = viewModel.Nome,
                Raca = viewModel.Raca,
                Especie = viewModel.Especie,
                Sobre = viewModel.Sobre,
                Vacinas = viewModel.Vacinas,
                Alergias = viewModel.Alergias,
                OutrasInformacoesMedicas = viewModel.OutrasInformacoesMedicas,
                Foto = viewModel.Foto,
                Idade = viewModel.Idade,
                Peso = viewModel.Peso,
                Altura = viewModel.Altura,
                Castrado = viewModel.Castrado,
                DataAdocao = viewModel.DataAdocao,
                Genero = (GeneroAnimal)viewModel.Genero,
                Status = (StatusInstituicao)viewModel.Status,
                ProtetorId = viewModel.ProtetorId,
                UsuarioId = viewModel.UsuarioId,
            };
        }
    }
}
